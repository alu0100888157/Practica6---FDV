using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso : MonoBehaviour
{

    private float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("ENTRAAAAAA");
            // Calculate Angle Between the collision point and the player
            Vector2 dir = new Vector2(0f, force);
            // We then get the opposite (-Vector3) and normalize it
            //dir = -dir.normalized;
            collision.attachedRigidbody.AddForce(dir * force ,ForceMode2D.Impulse);
        }
    }
}
