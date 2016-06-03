using UnityEngine;
using System.Collections;

public class ChoiseLevelPlanet : MonoBehaviour
{
    public Camera _camera;
    public GameObject planet;// массив планет

    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 
        {
            RaycastHit2D hit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform != null)
            {
                if (hit.collider.gameObject == planet)
                {
                 //   Debug.LogAssertion("pam");
                    Application.LoadLevel("01");
                }
            }
 
        }
    }
}