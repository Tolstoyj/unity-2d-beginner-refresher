using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class LevelManager : MonoBehaviour
{
    public GameObject winPanel;
    public string mainMenuSceneName = "MainMenu";

    private bool levelComplete;

    private void Start()
    {
        Time.timeScale = 1f;

        if (winPanel != null)
            winPanel.SetActive(false);
    }

    private void Update()
    {
        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
            return;

        if (levelComplete && keyboard.rKey.wasPressedThisFrame)
        {
            RestartLevel();
        }

        if (levelComplete && keyboard.mKey.wasPressedThisFrame)
        {
            LoadMainMenu();
        }
    }

    public void CompleteLevel()
    {
        if (levelComplete)
            return;

        levelComplete = true;

        Debug.Log("Level complete!");

        if (winPanel != null)
            winPanel.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
