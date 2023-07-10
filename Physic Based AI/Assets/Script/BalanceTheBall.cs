using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceTheBall : MonoBehaviour
{
    public GameObject Ball;
    public float BalancePoint = 0.5f;
    public float RotationSpeed = 10.0f;
    public bool collected;

    private void Start()
    {
        collected = true;
    }

    void Update()
    {
        // Get the position of the ball.
        Vector3 ballPosition = Ball.transform.position;

        // Calculate the distance of the ball from the balance point.
        float distanceFromBalancePoint = Mathf.Abs(ballPosition.x - BalancePoint);

        // Calculate the rotation amount.
        float rotationAmount = distanceFromBalancePoint * RotationSpeed;

        //StartCoroutine(startRotation());

        // Rotate the box.
        if(collected == true)
        {
            transform.Rotate(0, 0, rotationAmount);
        }
        else
        {
            transform.Rotate(0, 0, 0);
        }
    }
    IEnumerator startRotation()
    {
        yield return new WaitForSeconds(1f);
        collected = false;
    }
}
