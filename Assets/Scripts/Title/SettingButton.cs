using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingButton : MonoBehaviour
{
    public GameObject SettingPanel;

    [SerializeField]
    private bool isPanelOn;

    private void Start()
    {
        isPanelOn = false;
        SettingPanel.SetActive(false);
    }

    public void ClickSettingButton()
    {
        if (!isPanelOn)
        {
            SettingPanel.SetActive(true);
        }
        else
        {
            SettingPanel.SetActive(false);
        }

        isPanelOn = !isPanelOn;
    }
}
