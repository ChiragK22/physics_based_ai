using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BallManager : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public float waitTime;
   // public float randomForce;
    [Range(-1f, 1f)]
    public int floatRange;
    public string gameObejctName;

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


    //void OnCollisionEnter(Collision collision)
    //{
    //    // If the collision is with the plank, apply a random force to the ball.
    //    if (collision.gameObject.name == "Seasaw")
    //    {
    //        float forceAmount = Random.Range(-randomForce, randomForce);
    //        rigidbody.AddForce(Vector3.right * forceAmount);
    //    }
    //}



    void OnCollisionEnter(Collision collision)
    {
        // If the collision is with the plank, apply a random force to the ball.
        if (collision.gameObject.name == "Seasaw")
        {
            gameObejctName = gameObject.name;
            Debug.Log("Plank");
            float forceAmount = GetRandomForceDirection();
            Debug.Log("ForceAmount" + forceAmount);
            rigidbody.AddForce(Vector3.right * forceAmount);
           // Debug.Log(forceAmount);
        }
    }

    //float GetRandomForceDirection()
    //{
    //    // Get a random float between 0 and 1.
    //    float randomForce = Random.value;
    //    Debug.Log(randomForce);

    //    // If the random force is less than 0.5, return 0.
    //    if (randomForce < 0.5f)
    //    {
    //        return -1000f;
    //        Debug.Log("0");
    //    }

    //    // If the random force is between 0.5 and 1, return 0.5.
    //    else if (randomForce < 1.0f)
    //    {
    //        return 0f;
    //        Debug.Log("0.5");
    //    }

    //    // Otherwise, return 1.
    //    return 1000f;
    //    Debug.Log("1");
    //}

 
    float GetRandomForceDirection()
    { 
        // Create a list of the three possible values.
       
        // Get a random float between 0 and 1.
        //float randomForce = Random.value;

        //floatRange = Random.value;

        Debug.Log(floatRange);

        List<float> possible_values = new List<float>();
        possible_values.Add(-1000f);
        possible_values.Add(0f);
        possible_values.Add(1000f);
        possible_values.Add(-35000f);
        possible_values.Add(35000f);



        if (floatRange == -1)
        {
            if(gameObejctName == "Cone")
            {
                return possible_values[3];
                Debug.Log("CONE!S");
            }
            else
            {
                return possible_values[0];
            }
        }
        else if (floatRange == 0)
        {
            return possible_values[1];
            Debug.Log("Float range 0 ");
        }
        else
        {
            if (gameObejctName == "Cone")
            {
                return possible_values[4];
                Debug.Log("CONE!S");
            }
            else
            {
                return possible_values[2];
            }
            
        }
        //else if (randomForce > 0)
        //{
        //    return possible_values[2];
        //    Debug.Log("1000");
        //}
        //return possible_values[0];
        
        //// Otherwise, return 1000.
       // return possible_values[1];
        Debug.Log("Float range 0.5");
        //Debug.Log("1000");

        //if (randomForce < 0.4f)
        //{
        //    return possible_values[0];
        //    Debug.Log("-1000");
        //}

        //// If the random force is between 0.4 and 0.6, return 0.
        //else if (randomForce <= 0.6f && randomForce >= 0.4f)
        //{
        //    return possible_values[1];
        //    Debug.Log("0");
        //}

        //// Otherwise, return 1000.
        //return possible_values[2];
        //Debug.Log("1000");
    }

}