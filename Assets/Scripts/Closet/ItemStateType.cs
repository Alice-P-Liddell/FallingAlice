using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStateType : MonoBehaviour
{
    public enum ItemState                   //아이템의 상태를 나타낼 새 타입
    {
        Lock,       //미소유 상태
        Collected,  //보유 상태
        Using       //착용 상태
    }

    public ItemState itemState;             //현재 해당 아이템의 상태를 저장할 변수

    public GameObject lockPanel;            //Lock Panel 오브젝트를 저장할 변수

    public Image itemStateImage;            //ItemState Image오브젝트의 Image컴포넌트를 저장할 변수
    public Sprite lockSprite;               //Lock상태일때 ItemState Image에 표시될 자물쇠아이콘 스프라이트
    public Sprite checkSprite;              //Using상태일 때 ItemState Image에 표시될 체크아이콘 스프라이트
    public Sprite collectedSprite;          //Collected상태일 때 ItemState Image에 표시될 빈 스프라이트

    public GameObject buyPanel;             //팝업될 구매창 오브젝트
}
