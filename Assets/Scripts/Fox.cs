using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        GameObject otherGameobject = otherCollider.gameObject;
        
        if(otherGameobject.GetComponent<Gravestone>())
           {
                Jump();
           }

        else if (otherGameobject.GetComponent<Defender>() && !otherGameobject.GetComponent<Gravestone>())
        {
            GetComponent<Attacker>().Attack(otherGameobject);
        }
    }

    private void Jump()
    {
        GetComponent<Animator>().SetTrigger("jumpTrigger");
    }
}
