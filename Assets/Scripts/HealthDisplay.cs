using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] float baseHealth = 100;
    float health;
    TMP_Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        health = baseHealth - PlayerPrefsController.GetDifficulty() * 40;
        healthText = GetComponent<TMP_Text>();
        UpdateHealthDisplay();
    }


    private void UpdateHealthDisplay()
    {
        healthText.text = health.ToString();
    }
    public void LostHealth(int amount)
    {
        if (health >= amount)
        {
            health -= amount;
            UpdateHealthDisplay();
        }
        else if (health <= 0)
        {
            FindObjectOfType<LevelController>().LostCanvasDisplay();
            //FindObjectOfType<LevelLoad>().LoadGameOverScene();
        }
    }

    public void AddHealth(int amount)
    {
        health += amount;
        UpdateHealthDisplay();
    }
}
