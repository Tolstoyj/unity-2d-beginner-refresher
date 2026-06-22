using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public int score = 0;
    public SpriteScoreDisplay scoreDisplay;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        if (scoreDisplay == null)
            scoreDisplay = FindFirstObjectByType<SpriteScoreDisplay>();

        UpdateScoreDisplay();
    }

    public void AddScore(int amount)
    {
        score += amount;

        Debug.Log("Score: " + score);

        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        if (scoreDisplay != null)
            scoreDisplay.SetScore(score);
    }
}
