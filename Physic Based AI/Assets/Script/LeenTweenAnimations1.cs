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
    public float YellowWaitPTime1 = 7f;
    

    public void Start()
    {
        if (target != null)
        {
            LeanTween.move(target, new Vector3(1f, 22f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
            StartCoroutine(StartLeenTween());
        }

        //if (Yellow != null)
        //{
        //    LeanTween.move(Yellow, new Vector3(2.5f, 14f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        //    //StartAni();
        //    // StartCoroutine(StartLeenTweenY());
        //    yield return new WaitForSeconds(YellowWaitTime);
        //    if (cups.instance.empatyCup == "Cup1")
        //    {
        //        StartCoroutine(Start1LeenTweenY());
        //    }
        //    else if (cups.instance.empatyCup == "Cup2")
        //    {
        //        StartCoroutine(Start1LeenTweenY1());
        //    }

        //}
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
        if(cups.instance.empatyCup == "Cup1")
        {
            StartCoroutine(StartTweenY());
        }
        else if (cups.instance.empatyCup == "Cup2")
        {
            StartCoroutine(StartLeenTweenY1());
        }
        else
        {
            yield return new WaitForSeconds(3f);
            StartLeenTweenMethodYPast1();
        }
    }

    IEnumerator StartTweenY()
    {
        StartLeenTweenMethodYPast();
        yield return new WaitForSeconds(YellowWaitPTime1);
        StartLeenTweenMethodY2();
        yield return new WaitForSeconds(YellowWaitPTime);
        StartLeenTweenMethodYPast1();
    }
    

    IEnumerator StartLeenTweenY1()
    {
        //yield return new WaitForSeconds(YellowWaitTime);
        //StartLeenTweenMethodY();
        //yield return new WaitForSeconds(YellowWaitPTime);
        StartLeenTweenMethodYPast11();
        yield return new WaitForSeconds(YellowWaitPTime1);
        StartLeenTweenMethodY21();
        yield return new WaitForSeconds(YellowWaitPTime);
        StartLeenTweenMethodYPast1();
    }

    //Target
    void StartLeenTweenMethod()
    {
        LeanTween.move(target, new Vector3(1f, 0.5f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
    }
    void StartLeenTweenMethodPast()
    {
        LeanTween.move(target, new Vector3(1f, 22f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
    }

    // Yellow starting position
    void StartLeenTweenMethodY()
    {
        LeanTween.move(Yellow, new Vector3(2.5f, 2f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        LeanTween.move(Yellow1, new Vector3(-1.6f, 2f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        Debug.Log("Yellow starting position");
    }

    //Yellow up movement
    void StartLeenTweenMethodYPast()
    {
        LeanTween.move(Yellow, new Vector3(2.5f, 15f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        Debug.Log("Yellow up movement");
    }

    void StartLeenTweenMethodYPast11()
    {
        LeanTween.move(Yellow1, new Vector3(-1.6f, 15f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        Debug.Log("Yellow up movement");
    }


    //Yellow down movement
    void StartLeenTweenMethodY2()
    {
        LeanTween.move(Yellow, new Vector3(2.5f, 2f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        Debug.Log("Yellow down movement1");
    }

    void StartLeenTweenMethodY21()
    {
        LeanTween.move(Yellow1, new Vector3(-1.6f, 2f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        Debug.Log("Yellow down movement1");
    }
    //Yellow1 up movement
    void StartLeenTweenMethodYPast1()
    {
        LeanTween.move(Yellow1, new Vector3(-1.6f, 15f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        LeanTween.move(Yellow, new Vector3(2.5f, 15f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        Debug.Log("Yellow1 up movement");
    }
}
