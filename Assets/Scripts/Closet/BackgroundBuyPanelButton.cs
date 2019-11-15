using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundBuyPanelButton : MonoBehaviour
{
    public GameObject buyPanel;

    public void ClickBackgroundBuyPanel()
    {
        //this.GetComponentInParent<GameObject>().SetActive(false);
        buyPanel.SetActive(false);
    }
}
