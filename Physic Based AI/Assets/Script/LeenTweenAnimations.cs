using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeenTweenAnimations : MonoBehaviour
{
    public GameObject target;
    public GameObject Yellow;
    public float moveTime = 0f;
    public float waitTime = 5f;
    bool show;

    void Start()
    {
        show = false;
        if (target != null && show == false)
        {
            LeanTween.move(target, new Vector3(1f, -3.5f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
            StartCoroutine(ShowRedBlock());
        }

        if (Yellow != null)
        {
            LeanTween.move(Yellow, new Vector3(2.5f, 2f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
            StartCoroutine(StartLeenTweenY());
        }
    }

    IEnumerator StartLeenTween()
    {
        yield return new WaitForSeconds(waitTime);
        StartLeenTweenMethod();
    }

    IEnumerator ShowRedBlock()
    {
        yield return new WaitForSeconds(waitTime);
        LeanTween.move(target, new Vector3(1f, 0.5f, -6.5f), moveTime).setEase(LeanTweenType.easeInOutQuad);
        StartCoroutine(StartLeenTween());
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
        LeanTween.move(Yellow, new Vector3(15f, 2f, -4f), moveTime).setEase(LeanTweenType.easeInOutQuad);
    }
}
