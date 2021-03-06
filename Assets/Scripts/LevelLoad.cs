using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] float timeToWait = 4f;
    int currentSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
            
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }


    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
        Time.timeScale = 1;
    }



    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("StartMenuScene");
    }

    public void LoadTryAgainScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("StartMenuScene");
        Time.timeScale = 1;
    }

    public void LoadOptionsMenuScene()
    {
        SceneManager.LoadScene("OptionsMenuScene");
    }    

    public void QuitGame()
    {
        Application.Quit();
    }

}
