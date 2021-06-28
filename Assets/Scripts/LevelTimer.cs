using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] int timer = 60; // seconds

    // Update is called once per frame
    void Update()
    {
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / timer;

        bool timerIsFinished = (Time.timeSinceLevelLoad >= timer);
        if(timerIsFinished)
        {
            //ToDO
        }
    }
}
