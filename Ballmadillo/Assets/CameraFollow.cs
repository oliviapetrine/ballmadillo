using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float smoothSpeed = 0.125f;
    [SerializeField] Vector3 offset = new Vector3(0f, 3f, -10f);

    public Transform target;

    private void LateUpdate()
    {
        // If we don't have a target, find the winning player
        if (target == null)
        {
            // Find all objects with the Player tag
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

            // Set the target to the player with the highest y-position
            float highestYPos = float.MinValue;
            foreach (GameObject player in players)
            {
                float yPos = player.transform.position.y;
                if (yPos > highestYPos)
                {
                    highestYPos = yPos;
                    target = player.transform;
                }
            }
        }

        // If we have a target, follow it
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
