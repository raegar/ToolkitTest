using UnityEngine;

public class Wobble : MonoBehaviour
{
    public float wobbleAmount = 0.1f; // Adjust this value to control the intensity of the wobble
    public float wobbleSpeed = 2f; // Adjust this value to control the speed of the wobble
    private float originalY;

    void Start()
    {
        originalY = transform.position.y;
    }

    void Update()
    {
        // Calculate the new Y position using a sine wave
        float newY = originalY + Mathf.Sin(Time.time * wobbleSpeed) * wobbleAmount;

        // Update the position of the game object
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
