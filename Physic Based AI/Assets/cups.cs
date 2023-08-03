using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cups : MonoBehaviour
{
    public string cupsName;
    public static cups instance;
    public bool cup;
    public string empatyCup;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        cup = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cup1")
        {
            string cupsName = collision.gameObject.name;
            cups.instance.cup = true;
            Debug.Log(cupsName);
            empatyCup = "Cup1";
        }
        else if (collision.gameObject.name == "Cup1 (1)")
        {
            string cupsName = collision.gameObject.name;
            Debug.Log(cupsName);
            cups.instance.cup = true;
            empatyCup = "Cup2";
        }
    }
}
