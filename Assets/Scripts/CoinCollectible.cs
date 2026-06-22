using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    public int value = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore(value);
            }
            else
            {
                Debug.LogWarning("No ScoreManager found in the scene.");
            }

            Destroy(gameObject);
        }
    }
}
