using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButtonScript : MonoBehaviour {
    [SerializeField] DefenderScript defenderPrefab;
    void OnMouseDown() {
        var buttons = FindObjectsOfType<DefenderButtonScript>();
        foreach (DefenderButtonScript btn in buttons) {
            if (btn != this) {
                btn.GetComponent<SpriteRenderer>().color = new Color32(41,41,41,255);
            }
            else {
                GetComponent<SpriteRenderer>().color = Color.white;
                FindObjectOfType<DefenderSpawnerScript>().setSelectedDefender(btn.defenderPrefab);
            }
        }
    }
}
