using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControllerScript : MonoBehaviour {
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    [SerializeField] float waitToLoad = 4f;
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    void Start() {
        if (winLabel) {
            winLabel.SetActive(false);
        }

        if (loseLabel) {
            loseLabel.SetActive(false);
        }
    }

    public void AttackerSpawned() {
        numberOfAttackers++;
    }

    public void AttackerKilled() {
        numberOfAttackers--;
        if (numberOfAttackers <= 0 && levelTimerFinished && !loseLabel.active) {
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition() {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LevelLoaderScript>().LoadNextScene();
    }

    public void HandleLoseCondition() {
        loseLabel.SetActive(true);
        Time.timeScale = 0;
    }

    public void LevelTimerFinished() {
        levelTimerFinished = true;
        StopSpawners();
    }

    void StopSpawners() {
        AttackerSpawnerScript[] spawnerArray = FindObjectsOfType<AttackerSpawnerScript>();
        foreach (AttackerSpawnerScript spawner in spawnerArray) {
            spawner.StopSpawning();
        }
    }
}
