using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement2D : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        Vector3 movement = Vector3.zero;

        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
            return;

        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
            movement.x = -1f;

        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
            movement.x = 1f;

        if (keyboard.wKey.isPressed || keyboard.upArrowKey.isPressed)
            movement.y = 1f;

        if (keyboard.sKey.isPressed || keyboard.downArrowKey.isPressed)
            movement.y = -1f;

        transform.position += movement.normalized * speed * Time.deltaTime;
    }
}
