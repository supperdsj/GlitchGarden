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
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void StartGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 1");
    }
    public void LoadYouLose() {
        Time.timeScale = 1;
        SceneManager.LoadScene("LoseScreen");
    }
    public void LoadMainMenu() {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartScreen");
    }
    public void RestartScene() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
