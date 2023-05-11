using UnityEngine;

public class TiltMap : MonoBehaviour
{
    [SerializeField] float tiltSpeed = 1f;
    [SerializeField] float maxTiltAngle = 10f;
    [SerializeField] Transform character1;
    [SerializeField] Transform character2;

    void Update()
    {
        float tiltAngle = maxTiltAngle * Mathf.Sin(Time.time * tiltSpeed);
        transform.rotation = Quaternion.Euler(0f, 0f, tiltAngle);

        if (character1 != null)
        {
            Vector3 character1Pos = character1.position;
            character1Pos.z = Mathf.Lerp(character1Pos.z, -tiltAngle / 2f, Time.deltaTime);
            character1.position = character1Pos;
        }

        if (character2 != null)
        {
            Vector3 character2Pos = character2.position;
            character2Pos.z = Mathf.Lerp(character2Pos.z, tiltAngle / 2f, Time.deltaTime);
            character2.position = character2Pos;
        }
    }
} 
