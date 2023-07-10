using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeenTweenAnimations : MonoBehaviour
{
    public GameObject target;
    public GameObject Yellow;
    public float moveTime = 0f;
    public float waitTime = 5f;

    void Start()
    {
        if (target != null)
        {
            LeanTween.move(target, new Vector3(1f, 0.5f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
            StartCoroutine(StartLeenTween());
        }

        if (Yellow != null)
        {
            LeanTween.move(Yellow, new Vector3(2.5f, 2f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
            StartCoroutine(StartLeenTweenY());
        }
    }
    //void Update()
    //{
    //    StartCoroutine(StartLeenTween());
    //}

    IEnumerator StartLeenTween()
    {
        yield return new WaitForSeconds(waitTime);
        StartLeenTweenMethod();
    }

    IEnumerator StartLeenTweenY()
    {
        yield return new WaitForSeconds(waitTime);
        StartLeenTweenMethodY();
    }
    void StartLeenTweenMethod()
    {
        LeanTween.move(target, new Vector3(1f, -3.5f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
    }

    void StartLeenTweenMethodY()
    {
        LeanTween.move(Yellow, new Vector3(2.5f, 15f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
    }
}
