using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderShooter : MonoBehaviour
{
    [SerializeField]GameObject projectile, gun;

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shot()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }
}
