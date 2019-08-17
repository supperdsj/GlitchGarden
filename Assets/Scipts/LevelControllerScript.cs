using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControllerScript : MonoBehaviour {
    [SerializeField] GameObject winLabel;
    [SerializeField] float waitToLoad = 4f;
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    void Start() {
        winLabel.SetActive(false);
    }

    public void AttackerSpawned() {
        numberOfAttackers++;
    }

    public void AttackerKilled() {
        numberOfAttackers--;
        if (numberOfAttackers <= 0 && levelTimerFinished) {
            Debug.Log("finished");
            StartCoroutine(HandleWinCondition());
        }
    }

    IEnumerator HandleWinCondition() {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(waitToLoad);
        FindObjectOfType<LevelLoaderScript>().LoadNextScene();
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
