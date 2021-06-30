using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderShooter : MonoBehaviour
{
    [SerializeField]GameObject projectile, gun;
    AttackerSpawner myLaneSpawner;
    Animator animator;
    GameObject projectileParent;
    const string PROJECTILE_PARENT_NAME = "Projectiles";







    private void Start()
    {
        CreateProjectileParent();
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
        GameObject newProjectile = Instantiate(projectile, gun.transform.position, transform.rotation) as GameObject;
        newProjectile.transform.parent = projectileParent.transform;
    }


    private void CreateProjectileParent()
    {
        projectileParent = GameObject.Find(PROJECTILE_PARENT_NAME);
        if (!projectileParent)
        {
            projectileParent = new GameObject(PROJECTILE_PARENT_NAME);
        }
    }
}
