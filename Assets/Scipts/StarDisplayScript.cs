using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplayScript : MonoBehaviour {
    [SerializeField] int stars = 100;
    Text starText;

    void Start() {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    void UpdateDisplay() {
        starText.text = stars.ToString();
    }

    public void AddStars(int starToAdd) {
        stars += starToAdd;
        UpdateDisplay();
    }

    public void SpendStars(int starToSpend) {
        if (HaveEnouthStars(starToSpend)) {
            stars -= starToSpend;
            UpdateDisplay();
        }
    }

    public bool HaveEnouthStars(int amount) {
        return stars >= amount;
    }
}
