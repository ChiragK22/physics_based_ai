using UnityEngine;

public class plank : MonoBehaviour
{
    public Transform sphere;
    public float rotationSpeed;
    public float collisionRadius;

    Vector3 sphereDirection;
    float rotationAmount;

    bool isRotating;

    void Update()
    {
        // Calculate the direction of the sphere.
        sphereDirection = sphere.position - transform.position;

        // Calculate the rotation amount.
        rotationAmount = sphereDirection.x * rotationSpeed * Time.deltaTime;

        // If the sphere has collided with the plank, start rotating.
        if (Physics.SphereCast(transform.position, collisionRadius, sphere.position, out RaycastHit hit))
        {
            isRotating = true;
        }

        // If the plank is rotating, rotate it.
        if (isRotating)
        {
            transform.Rotate(0, 0, rotationAmount);
        }
    }
}

