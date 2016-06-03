using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class Controller : MonoBehaviour {
	public GameObject GameOVER;
	public Text LifeText;
	public Text ProjectailText;
	public Text MoneyText;
    bool _jump = false;
//	public MoveBacground[] move;
	public GameObject Winer;
    public GameObject projectail;
    public GameObject ShootPosition;
    private bool _isGrounded;
    private float _radius = 0.7f;
    private float _force = 60f;
    bool click = false;
	private int _projectail=2;
	private int _life=3;
    // GameComponent
    public Transform CoinsParent;
    public Transform GroundPoint;
    public Transform CenterPoint;
    public LayerMask Ground;
    public LayerMask _Ground;
    public AudioSource Audio;
    public AudioClip Jump;
    public AudioClip Coin;
    public AudioClip Win;
    public Animator Anim;
    public Rigidbody2D rigidbody2D;
    public int coins;
    public int level;
    public int nextlevel;
	public float timer;
    //Game reference
    public TextMesh Score;
    public GameObject[] Coins;
    bool _isDamage=false;
	bool _shoot;
    // Use this for initialization
    void Start () {

    }
	void Update(){
		if (Input.GetMouseButtonDown (0)&&!_jump&&!_shoot) 
			StartCoroutine(Jumped());
		
		if (Input.GetMouseButtonDown (2) && !_jump&&!_shoot) {
			StartCoroutine(Shoot());
		}
	}
    void FixedUpdate()
	{
		if (_life <= 0) {
			GameOver ();
		}
		if (timer <= 2) {
			timer -= 0.05f;
		}

        if (_isDamage)
		{
			if (timer <= 0) {
				_life--;
				timer = 2;
			} 
			LifeText.text=_life + "";;


            Anim.SetBool("Damage", true);
			if(_life>0)
            StartCoroutine(Damage());
        }
    }
    IEnumerator Damage()
    {
        yield return new WaitForSeconds(0.2f);
        Anim.SetBool("Damage", false);

    }
	

    IEnumerator Jumped()
    {
       // Audio.Play();
		Anim.SetBool("Jump",true);
		_jump=true;
        yield return new WaitForSeconds(0.1f);
        rigidbody2D.AddForce(Vector2.up * _force * 10000 * Time.deltaTime);
     //   Audio.clip = Jump;
        //Audio.Play();
        yield return new WaitForSeconds(0.9f);
     //   Anim.SetBool("Jump", false);
       // yield return new WaitForSeconds(0.1f);
		Anim.SetBool("Jump",false);
        click = false;
        _jump = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            coins++;
            Score.text = coins + "";
            Destroy(other.gameObject);
            Audio.clip = Coin;
            Audio.Play();
        }
  

        else if (other.tag == "DeadZone")
        {
            Application.LoadLevel(level);
        }
        else if (other.tag == "Finish")
        {
            Audio.clip = Win;
            Audio.Play();
			MoneyText.text=coins+"";
			Winer.SetActive (true);
			this.gameObject.SetActive (false);
			//move [0].enabled = false;
			//move [1].enabled = false;
            
        }
    }

    IEnumerator Nextlevel()
    {
        yield return new WaitForSeconds(1.5f);
        // yield retun new Wai
        if (coins == Coins.Length)
        {
            Application.LoadLevel(4);
        }
        if (coins == Coins.Length-2|| coins == Coins.Length - 1)
        {
            Application.LoadLevel(3);
        }
        if (coins < Coins.Length-2)
        {
            Application.LoadLevel(2);
        }
    }
	public IEnumerator Shoot()
	{_shoot = true;
		Anim.SetBool ("Shoot", true);
		yield return new WaitForSeconds(0.5f);
		Anim.SetBool ("Shoot", false);
		_shoot = false;
    }

    IEnumerator Run()
    {
        yield return new WaitForSeconds(0.5f);
        projectail.SetActive(true);
        Anim.SetBool("Shoot", false);
        projectail.transform.position = ShootPosition.transform.position;
        yield return new WaitForSeconds(1f);
        Anim.SetBool("Shoot", false);
        projectail.SetActive(false);
        click = false;
    }
	void GameOver(){
		
		GameOVER.SetActive (true);
		//move [0].enabled = false;
		//move [1].enabled = false;
	//	this.gameObject.SetActive (false);
		Time.timeScale = 0;
		this.gameObject.SetActive (false);
	}
}
