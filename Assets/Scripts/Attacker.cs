using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0,5)]
    [SerializeField] float currentMoveSpeed = 1f;
    GameObject currentTarget;
    [SerializeField] int damageToPlayer = 20;


    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        FindObjectOfType<LevelController>().AddEnemy();
    }


    void Update()
    {
        transform.Translate(Vector2.left * currentMoveSpeed * Time.deltaTime);
        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (!currentTarget)
        {
            GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    public void SetMovementSpeed(float speed)
    {
        currentMoveSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("isAttacking", true);
        currentTarget = target;

    }

    public void StrikeCurrentTarget(float damage)
    {
        if(!currentTarget) { return; }
        Health health = currentTarget.GetComponent<Health>();
        if(health)
        {
            health.DoDamage(damage);
        }
    }

    public int DamageToPlayer()
    {
        return damageToPlayer;
    }

}
