using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderShooter : MonoBehaviour
{
    [SerializeField]GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        SetLaneSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if(AttackerInLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }


    void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        
        foreach (AttackerSpawner spawner in spawners)
        {
            bool isInLine = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if(isInLine)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    bool AttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    void Shot()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);
    }
}
