using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabController : MonoBehaviour
{
    private bool pressx = false;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && !pressx)
        {
            Debug.Log("ENTRA");
            animator.SetBool("PressX", true);
            pressx = true;
        }
        else if (Input.GetKeyDown(KeyCode.X) && pressx)
        {
            Debug.Log("ENTRA2");
            animator.SetBool("PressX", false);
            pressx = false;
        }


    }
}
