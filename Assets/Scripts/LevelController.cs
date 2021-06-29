using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] int enemies = 0; //number of enemies on level
    bool isTimerFinished = false;
    [SerializeField] GameObject winCanvas;
    [SerializeField] GameObject lostCanvas;
    [SerializeField] float timeToWait = 2f;


    public void AddEnemy()
    {
        enemies++;
    }

    public void SubEnemy()
    {
        enemies--;
        if(enemies <=0 && isTimerFinished)
        {
            
            winCanvas.SetActive(true);
            StartCoroutine(WaitForTimeForNextLevel());
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
    public void LostCanvasDisplay()
    {
        lostCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    IEnumerator WaitForTimeForNextLevel()
    {
        yield return new WaitForSeconds(timeToWait);
        FindObjectOfType<LevelLoad>().LoadNextScene();
        


    }

}
