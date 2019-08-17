using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimerScript : MonoBehaviour {
    [Tooltip("levelTime value type is SEC")] [SerializeField]
    float levelTime = 20;

    bool triggeredLevelFinished = false;

    // Update is called once per frame
    void Update() {
        if (triggeredLevelFinished) {
            return;
        }

        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        bool timerFinished = Time.timeSinceLevelLoad >= levelTime;
        if (timerFinished) {
            FindObjectOfType<LevelControllerScript>().LevelTimerFinished();
            triggeredLevelFinished = true;
            // Debug.Log("level timer expired!");
        }
    }
}
