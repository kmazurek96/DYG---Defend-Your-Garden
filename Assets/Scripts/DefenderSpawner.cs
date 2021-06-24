using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;

    private void OnMouseDown()
    {
        SpawnDefender(GetClickPos());
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    Vector2 GetClickPos()
    {
        
        Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(pos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;

    }

    Vector2 SnapToGrid(Vector2 rawWorldPost)
    {
        float newX = Mathf.RoundToInt(rawWorldPost.x);
        float newY = Mathf.RoundToInt(rawWorldPost.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 gridPos)
    {
        Defender newDefender = Instantiate(defender, gridPos, transform.rotation) as Defender;
    }
}
