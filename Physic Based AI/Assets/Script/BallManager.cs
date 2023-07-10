using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallManager : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float waitTime;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    void Update()
    {
        StartCoroutine(unableGravity());
    }

    IEnumerator unableGravity()
    {
        yield return new WaitForSeconds(waitTime);
        rigidbody.useGravity = true;
    }
}