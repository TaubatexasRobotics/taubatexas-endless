using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D col;
    public Vector2 BoxSize;


    public int JumpForce;
    public bool grounded = true;
    public float castDistance;
    public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<BoxCollider2D>();
    }


    void Update()
    {
        //Se o player estiver no chão e apertar Z, ele pula
        if(Input.GetKeyDown("z") && isGrounded() == true){
            Jump();
        }
    }


    void Jump(){
        rb.velocity = new Vector3(0,0,0);
        rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
    }

    public bool isGrounded(){
        if(Physics2D.BoxCast(transform.position, BoxSize, 0, -transform.up, castDistance, groundLayer)){
            return true;
        }else{
            return false;
        }
    }

    private void OnDrawGizmos(){
        Gizmos.DrawWireCube(transform.position-transform.up * castDistance, BoxSize);
    }
}
