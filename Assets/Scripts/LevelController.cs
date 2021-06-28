using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] int enemies;

    void Start()
    {
        enemies = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddEnemy()
    {
        enemies++;
    }

    public void SubEnemy()
    {
        enemies--;
    }

}
