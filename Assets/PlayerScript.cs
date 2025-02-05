using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int moveSpeed = 5;
        Vector3 v = rb.velocity;
        if(GoalScript.isGameClear == false)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                v.x = moveSpeed;
            }
            else
            {
                v.x = 0;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                v.x = -moveSpeed;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                v.y = 3;
            }

            rb.velocity = v;
        }
    }
}
