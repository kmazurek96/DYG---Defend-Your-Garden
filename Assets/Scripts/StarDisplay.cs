using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    TMP_Text starText;
    void Start()
    {
        starText = GetComponent<TMP_Text>();
        UpdateStarDisplay();
    }

    void UpdateStarDisplay()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(int amount )
    {
        stars += amount;
        UpdateStarDisplay();
    }

    public void SpendStars (int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            UpdateStarDisplay();
        }
    }
}

