using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if(otherCollider.GetComponent<Attacker>())
        {
            int damage = otherCollider.GetComponent<Attacker>().DamageToPlayer();
            FindObjectOfType<HealthDisplay>().LostHealth(damage);
            Destroy(otherCollider.gameObject);
        }
    }
}
