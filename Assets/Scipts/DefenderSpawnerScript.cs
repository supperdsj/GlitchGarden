using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawnerScript : MonoBehaviour {
    [SerializeField] GameObject defender;
    void OnMouseDown() {
        SpawnDefender(GetSquareClicked());
    }

    void SpawnDefender(Vector2 worldPos) {
        GameObject newDefender = Instantiate(defender, worldPos, Quaternion.identity);
    }

    Vector2 GetSquareClicked() {
        Vector2 clickPos=new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    Vector2 SnapToGrid(Vector2 roundedPos) {
        float newX = Mathf.RoundToInt(roundedPos.x);
        float newY= Mathf.RoundToInt(roundedPos.y);
        return new Vector2(newX,newY);
    }
}
