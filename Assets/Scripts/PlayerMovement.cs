using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator animator;
    private float velocidadvert;
    private float velocidadhor;
    private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocidadhor = Input.GetAxisRaw("Horizontal") * speed;
        Vector2 movement = new Vector2(velocidadhor, velocidadvert);
        movement *= Time.deltaTime;

        transform.Translate(movement);

        if (Input.GetButtonDown("Horizontal"))
        {
            Debug.Log(velocidadhor);
            if (velocidadhor > 0)
            {
                this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
                animator.SetBool("right", true);
            }
            else
            {
                this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
                animator.SetBool("right", true);
            }

        }
        else
        {
            if (Input.GetButtonDown("Jump"))
            {
                this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
                animator.SetBool("ground", false);
                animator.SetBool("jump", true);
                animator.SetBool("right", false);
            }
            else
            {
                if(movement  == Vector2.zero)
                {
                    //Debug.Log("Se queda false");
                    animator.SetBool("right", false);
                }

            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            animator.SetBool("ground",true);
            animator.SetBool("jump", false);
        }
    }
}
