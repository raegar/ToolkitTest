using UnityEngine;

public class GrowAndShrink : MonoBehaviour
{
    public float maxSize = 2f; // Adjust this value to set the maximum size
    public float minSize = 0.5f; // Adjust this value to set the minimum size
    public float growthSpeed = 1f; // Adjust this value to control the speed of growth
    private bool growing = true;

    void Update()
    {
        // Scale the object up or down depending on the current state
        if (growing)
        {
            transform.localScale += Vector3.one * growthSpeed * Time.deltaTime;
            if (transform.localScale.x >= maxSize)
            {
                growing = false;
            }
        }
        else
        {
            transform.localScale -= Vector3.one * growthSpeed * Time.deltaTime;
            if (transform.localScale.x <= minSize)
            {
                growing = true;
            }
        }
    }
}
