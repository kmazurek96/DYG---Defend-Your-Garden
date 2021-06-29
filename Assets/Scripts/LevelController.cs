using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] int enemies = 0; //number of enemies on level
    bool isTimerFinished = false;
     

    public void AddEnemy()
    {
        enemies++;
    }

    public void SubEnemy()
    {
        enemies--;
        if(enemies <=0 && isTimerFinished)
        {

        }
    }

    public void LevelTimerFinished()
    {
        isTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }

}
