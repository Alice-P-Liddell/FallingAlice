using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameStart : MonoBehaviour
{
    Transform aliceTr;

    void Start()
    {
        aliceTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        StartCoroutine("StartAnim");
        Debug.Log("Started!"); 
    }

    IEnumerator StartAnim()
    {
        // Translate(이동속도, 기준좌표)
        //aliceTr.Translate(10 * Time.deltaTime, 0, 0, 0);
        transform.DOMoveY(0, 2).SetEase(Ease.Unset);
        Debug.Log("Moving!");

        yield return null;
    }
}
