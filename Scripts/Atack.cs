using UnityEngine;
using System.Collections;

public class Atack : MonoBehaviour {
    public Animator anim;
    public Transform Point;
    private float _radius = 5f;
    public LayerMask Ground;
    bool _isAtack = false;
    // Use this for initialization
    void Start () {

    }
    void FixedUpdate()
    {
        _isAtack = Physics2D.OverlapCircle(Point.position, _radius, Ground);
        if (_isAtack)
        {
            anim.SetBool("Atack", true);
        }
    }


// Update is called once per frame
void OntriggerStay2D(Collider2D other) {
        if(other.tag == "Player")
        {
         
        }
	
	}
}
