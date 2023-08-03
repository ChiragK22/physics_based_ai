using UnityEngine;
using System.Collections;

public class plank : MonoBehaviour
{
    public Transform sphere;
    public float rotationSpeed;
    public float collisionRadius;
    public float wait;

    Vector3 sphereDirection;
    float rotationAmount;
    public GameObject sphereObject;

    bool isRotating;
    Vector3 initialPosition;
    Quaternion initialRotation;

    private void Start()
    {
        sphereObject = GameObject.Find("Sphere");
        StartCoroutine(SphereCollection());

        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    IEnumerator SphereCollection()
    {
        yield return new WaitForSeconds(wait);
        sphere = sphereObject.transform;
    }

    void Update()
    {
        // Calculate the direction of the sphere.
        if(sphere != null)
        {
            sphereDirection = sphere.position - transform.position;
        }

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

        if(cups.instance.cup == true)
        {
            transform.Rotate(0, 0, 0);
            sphere = null;

            transform.position = initialPosition;
            transform.rotation = initialRotation;
        }
    }
}

