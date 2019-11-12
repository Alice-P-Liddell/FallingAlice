using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TileMap : MonoBehaviour
{
    public GameObject startTile;
    public GameObject alice;

    // Start is called before the first frame update
    void Start()
    {
        alice.transform.DOMoveY(2, 2).SetEase(Ease.InOutQuad);
        StartCoroutine("StartMap");
    }

    IEnumerator StartMap()
    {
        startTile.transform.DOMoveY(0, 4f).SetEase(Ease.InQuad);
        startTile.transform.DOMoveY(32, 5f).SetEase(Ease.Linear);
        
        yield return new WaitForSeconds(5);

        Destroy(startTile);
    }
}
