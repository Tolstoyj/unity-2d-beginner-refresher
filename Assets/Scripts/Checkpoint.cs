using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Transform respawnPoint;

    public Color inactiveColor = Color.green;
    public Color activeColor = Color.yellow;

    private SpriteRenderer spriteRenderer;
    private bool activated;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (respawnPoint == null)
            respawnPoint = transform;

        if (spriteRenderer != null)
            spriteRenderer.color = inactiveColor;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.SetSpawnPoint(respawnPoint);
            ActivateCheckpoint();
        }
    }

    private void ActivateCheckpoint()
    {
        if (activated)
            return;

        activated = true;

        if (spriteRenderer != null)
            spriteRenderer.color = activeColor;

        Debug.Log("Checkpoint activated: " + gameObject.name);
    }
}
