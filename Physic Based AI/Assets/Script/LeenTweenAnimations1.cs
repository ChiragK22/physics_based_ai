using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeenTweenAnimations1 : MonoBehaviour
{ 
    public GameObject target;
    public GameObject Yellow;
    public GameObject Yellow1;
    public float moveTime = 0f;
    public float RedwaitTime = 5f;
    public float YellowWaitTime = 5f;
    public float RedwaitPTime = 5f;
    public float YellowWaitPTime = 5f;

    void Start()
    {
        if (target != null)
        {
            LeanTween.move(target, new Vector3(1f, 22f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
            StartCoroutine(StartLeenTween());
        }

        if (Yellow != null)
        {
            LeanTween.move(Yellow, new Vector3(2.5f, 14f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
            StartCoroutine(StartLeenTweenY());
        }
        if (Yellow1 != null)
        {
            LeanTween.move(Yellow1, new Vector3(-1.6f, 14f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
            StartCoroutine(StartLeenTweenY());
        }
    }
    //void Update()
    //{
    //    StartCoroutine(StartLeenTween());
    //}

    IEnumerator StartLeenTween()
    {
        yield return new WaitForSeconds(RedwaitTime);
        StartLeenTweenMethod();
        yield return new WaitForSeconds(RedwaitPTime);
        StartLeenTweenMethodPast();
    }


    IEnumerator StartLeenTweenY()
    {
        yield return new WaitForSeconds(YellowWaitTime);
        StartLeenTweenMethodY();
        yield return new WaitForSeconds(YellowWaitPTime);
        StartLeenTweenMethodYPast();
    }


    void StartLeenTweenMethod()
    {
        LeanTween.move(target, new Vector3(1f, 0.5f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
    }
    void StartLeenTweenMethodPast()
    {
        LeanTween.move(target, new Vector3(1f, 22f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
    }

    void StartLeenTweenMethodY()
    {
        LeanTween.move(Yellow, new Vector3(2.5f, 2f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        LeanTween.move(Yellow1, new Vector3(-1.6f, 2f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
    }
    void StartLeenTweenMethodYPast()
    {
        LeanTween.move(Yellow, new Vector3(2.5f, 15f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        LeanTween.move(Yellow1, new Vector3(-1.6f, 15f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
    }
}
