using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawnerScript : MonoBehaviour {
    DefenderScript defender;

    void OnMouseDown() {
        AttemptToPlaceDefenderAt(GetSquareClicked());
    }

    void SpawnDefender(Vector2 worldPos) {
        DefenderScript newDefender = Instantiate(defender, worldPos, Quaternion.identity);
    }

    Vector2 GetSquareClicked() {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }

    Vector2 SnapToGrid(Vector2 roundedPos) {
        float newX = Mathf.RoundToInt(roundedPos.x);
        float newY = Mathf.RoundToInt(roundedPos.y);
        return new Vector2(newX, newY);
    }

    public void setSelectedDefender(DefenderScript defenderToSelect) {
        defender = defenderToSelect;
    }

    public void AttemptToPlaceDefenderAt(Vector2 gridPos) {
        var StarDisplay = FindObjectOfType<StarDisplayScript>();
        if (defender) {
            int defenderCost = defender.GetStarCost();
            if (StarDisplay.HaveEnouthStars(defenderCost)) {
                SpawnDefender(gridPos);
                StarDisplay.SpendStars(defenderCost);
            }
        }
    }
}
