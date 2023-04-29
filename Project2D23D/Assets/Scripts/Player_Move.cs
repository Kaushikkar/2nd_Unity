using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{   
    [SerializeField]Ground_check ground_Check;
    private float move_horizontal;
    //[SerializeField]bool ground_check=false;
    private Rigidbody rb;
    //private  float move_vertical;
    [SerializeField]float jump_force;
    [SerializeField]float speed;

    void Update()
    {
        ground_Check=GetComponent<Ground_check>();
        move_horizontal=Input.GetAxis("Horizontal")*speed*Time.fixedDeltaTime;
        //move_vertical=Input.GetAxis("Vertical")*speed*Time.fixedDeltaTime;
        transform.Translate(move_horizontal,0f,0f);
        if(Input.GetKeyDown("space")&&ground_Check.IsGrounded)
        {
            jump();
        }
    }
    void jump()
    {
        rb=GetComponent<Rigidbody>();
        rb.AddForce(transform.up*jump_force);
    }
    
}
