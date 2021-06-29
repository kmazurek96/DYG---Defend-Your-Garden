using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] int timer = 60; // seconds
    bool triggeredLevelFinished = false;

    // Update is called once per frame
    void Update()
    {
        if (triggeredLevelFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / timer;

        bool timerIsFinished = (Time.timeSinceLevelLoad >= timer);
        if(timerIsFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            triggeredLevelFinished = true;
        }
    }
}
