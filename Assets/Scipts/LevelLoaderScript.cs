using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour {
    int currentSceneIndex;

    void Start() {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Debug.Log(currentSceneIndex);
        if (currentSceneIndex == 0) {
            StartCoroutine(WaitForTimeToLoadNextScene(4));
        }
    }

    IEnumerator WaitForTimeToLoadNextScene(float timeToWait) {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene() {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void LoadYouLose() {
        SceneManager.LoadScene("LoseScreen");
    }
    public void LoadMainMenu() {
        SceneManager.LoadScene("StartScreen");
    }
    public void RestartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
