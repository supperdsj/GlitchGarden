using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControllerScript : MonoBehaviour {
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;

    public void AttackerSpawned() {
        numberOfAttackers++;
    }

    public void AttackerKilled() {
        numberOfAttackers--;
        if (numberOfAttackers <= 0 && levelTimerFinished) {
            Debug.Log("End level now");
        }
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
