using UnityEngine;

public class LevelGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        LevelManager levelManager = FindFirstObjectByType<LevelManager>();

        if (levelManager != null)
        {
            levelManager.CompleteLevel();
        }
        else
        {
            Debug.LogWarning("No LevelManager found in the scene.");
        }
    }
}
