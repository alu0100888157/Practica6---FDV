using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusMovement : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("entra trigger");
            animator.SetTrigger("colision");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("entra trigger");
            animator.SetTrigger("noColision");
        }
    }
}
