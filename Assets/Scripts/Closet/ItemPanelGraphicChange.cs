using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPanelGraphicChange : ItemStateType
{
    public void SetUsing()
    {
        Debug.Log("유징 상태입니다.");
        itemStateImage.sprite = checkSprite;        //ItemState Image오브젝트의 Image컴포넌트의 Source Image를 Check로 변경
        lockPanel.SetActive(false);                 //LockPanel 오브젝트를 셋엑티브비활성화
    }

    public void SetCollected()
    {
        Debug.Log("컬렉티드 상태입니다.");
        itemStateImage.sprite = collectedSprite;    //ItemState Image오브젝트를 셋엑티브비활성화 - 대신 none스프라이트로 변경
        lockPanel.SetActive(false);                 //LockPanel 오브젝트를 셋엑티브비활성화
    }

    public void SetLock()
    {
        Debug.Log("락 상태입니다.");
        itemStateImage.sprite = lockSprite;         //ItemState Image오브젝트의 Image컴포넌트의 Source Image를 Lock으로 변경
        lockPanel.SetActive(true);                  //LockPanel 오브젝트를 셋엑티브활성화
    }
}
