using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Transform spawnPoint;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetSpawnPoint(Transform newSpawnPoint)
    {
        spawnPoint = newSpawnPoint;
        Debug.Log("New checkpoint set: " + newSpawnPoint.name);
    }

    public void Respawn()
    {
        if (spawnPoint == null)
        {
            Debug.LogWarning("SpawnPoint is not assigned.");
            return;
        }

        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;

        transform.position = spawnPoint.position;

        Debug.Log("Player respawned!");
    }
}
