using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0,5)]
    [SerializeField] float currentMoveSpeed = 1f;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * currentMoveSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentMoveSpeed = speed;
    }
}
