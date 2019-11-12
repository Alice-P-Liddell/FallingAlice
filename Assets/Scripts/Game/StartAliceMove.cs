using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StartAliceMove : MonoBehaviour
{
    void Start()
    {
        transform.DOMoveY(2, 2).SetEase(Ease.InOutQuad);
    }
}
