using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    SpriteRenderer sprite;
    TMP_Text costText;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        costText = GetComponentInChildren<TMP_Text>();
        if (!costText)
        {
            Debug.LogError("No text");
        }
        else
        {
            costText.text = defenderPrefab.GetStarCost().ToString();
        }
    }

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = Color.black;
           
        }
        sprite.color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
