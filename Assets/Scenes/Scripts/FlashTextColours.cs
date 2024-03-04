using UnityEngine;
using TMPro;

public class FlashTextColors : MonoBehaviour
{
    public Color[] colors; // Array of colors to flash
    public float flashSpeed = 1; // Speed of the color change
    public TextMeshProUGUI textMeshPro;
    private int currentIndex = 0;
    private float timer = 0f;

    void Start()
    {
        //textMeshPro = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // If enough time has passed, change the color
        if (timer >= 1f / flashSpeed)
        {
            // Change to the next color in the array
            currentIndex = (currentIndex + 1) % colors.Length;
            textMeshPro.color = colors[currentIndex];
            
            // Reset the timer
            timer = 0f;
        }
    }
}
