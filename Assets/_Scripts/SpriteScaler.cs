using UnityEngine;

public class SpriteScaler : MonoBehaviour
{
    public float scaleSpeed = 1f; // Speed at which the sprite scales
    public float maxScale = 2f; // Maximum scale of the sprite
    public float minScale = 0.5f; // Minimum scale of the sprite

    private bool scalingUp = true; // Whether the sprite is currently scaling up or down
    private Vector3 initialScale; // Initial scale of the sprite

    private void Start()
    {
        initialScale = transform.localScale; // Store the initial scale of the sprite
    }

    private void Update()
    {
        // Determine the direction of the scaling based on whether the sprite is currently scaling up or down
        float scaleDirection = scalingUp ? 1f : -1f;

        // Scale the sprite in the desired direction
        transform.localScale += new Vector3(scaleDirection, scaleDirection, scaleDirection) * scaleSpeed * Time.deltaTime;

        // If the sprite has reached the maximum scale, start scaling down
        if (scalingUp && transform.localScale.x >= maxScale)
        {
            scalingUp = false;
        }

        // If the sprite has reached the minimum scale, start scaling up
        if (!scalingUp && transform.localScale.x <= minScale)
        {
            scalingUp = true;
        }
    }
}
