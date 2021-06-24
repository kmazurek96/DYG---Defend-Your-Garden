using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 200;
 

    // Update is called once per frame

    public void DoDamage(float damage)
    {
        health -= damage;
        if (health <= 0 )
        {
            Destroy(gameObject);
        }
    }
}
