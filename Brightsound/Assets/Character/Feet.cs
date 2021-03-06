﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : MonoBehaviour {

    //[HideInInspector]
    public bool isGrounded = false;

    [SerializeField]
    private Player parent;
       
    void OnTriggerStay2D(Collider2D other)
    {              
        if (other.CompareTag("Ground") || other.CompareTag("SolidPlatform") || other.CompareTag("ThroughPlatform"))
        {
            Rigidbody2D playerRB = transform.parent.GetComponent<Rigidbody2D>();
            if (playerRB.velocity.y <= 0.01f)
            {
                isGrounded = true;
                //Physics2D.IgnoreCollision(this.transform.parent.GetComponent<Collider2D>(), other, true);
            }
                     
        }        
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ground") || other.CompareTag("SolidPlatform") || other.CompareTag("ThroughPlatform"))
        {
            isGrounded = false;
        }
    }
}
