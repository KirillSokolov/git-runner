using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
    public Animator anim;
    public int hp;
    public float _radius;
    public LayerMask Ground;
    public Transform Point;
    bool _isAtack=false;
    public enum Monsters { AQVA,Kaktus};
    public Monsters _monsterType;
    // Use this for initialization
    public Collider2D _collder;
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate() {
        _isAtack = Physics2D.OverlapCircle(Point.position, _radius, Ground);
        if (_isAtack)
        {
            hp--;
        }
        if (hp <= 0)
        {
            anim.SetBool("Die", true);
            _collder.enabled = false;
        }
	}
    void OntriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Projectail")
            hp--;
    }

}
