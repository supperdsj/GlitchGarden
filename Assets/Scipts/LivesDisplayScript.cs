using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LivesDisplayScript : MonoBehaviour {
    [SerializeField] int lives = 5;
    [SerializeField] int damage = 1;
    Text liveText;

    void Start() {
        liveText = GetComponent<Text>();
        UpdateDisplay();
    }

    void UpdateDisplay() {
        liveText.text = lives.ToString();
    }

    public void TakeLife() {
        lives -= damage;
        UpdateDisplay();
        if (lives <= 0) {
            // FindObjectOfType<LevelLoaderScript>().LoadYouLose();
            FindObjectOfType<LevelControllerScript>().HandleLoseCondition();
        }
    }
}

