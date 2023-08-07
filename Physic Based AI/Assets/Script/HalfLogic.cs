using UnityEngine;

public class HalfLogic : MonoBehaviour
{
    public GameObject woodenHalf;
    public GameObject plasticHalf;

    void Start()
    {
        // Get the center of mass of the wooden half.
        Vector3 woodenHalfCenterOfMass = woodenHalf.transform.position;

        // Get the center of mass of the plastic half.
        Vector3 plasticHalfCenterOfMass = plasticHalf.transform.position;

        // Calculate the center of mass of the sphere.
        Vector3 sphereCenterOfMass = (woodenHalfCenterOfMass + plasticHalfCenterOfMass) / 2;

        // Set the sphere's center of mass.
        transform.position = sphereCenterOfMass;
    }
}
