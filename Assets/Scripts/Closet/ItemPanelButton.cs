using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPanelButton : MonoBehaviour
{
    public enum ItemState                           //아이템의 상태
    {
        Lock,       //미소유 상태
        Collected,  //보유 상태
        Using       //착용 상태
    }

    public ItemState itemState;

    public void ClickPanel()                        //패널을 터치했을 경우 호출
    {
        //itemState = ItemState.Lock;

        if (itemState == ItemState.Using)           //유징상태라면 컬렉티드 상태로
        {
            Debug.Log("해제");
            itemState = ItemState.Collected;
            //앨리스를 안입은 상태로 만들기
            //안입은 상태에 대한 씬 내의 변경사항은 아이템패널 스크립트에 따로 구현
        }
        else if (itemState == ItemState.Collected)  //컬렉티드상태라면 유징상태로
        {
            Debug.Log("착용");
            itemState = ItemState.Using;
            //다른 유징상태의 패널을 컬렉티드 상태로 바꾸기

            //앨리스 스프라이트를 해당 아이템 착용 상태로 만들기
            //각 상태에 따른 씬 내의 변경사항은 아이템패널 스크립트에 따로 구현
        }
        else                                        //락상태라면 구매확인 창 띄우기
        {
            //구매창 함수 호출
        }
            
    }

    //구매창 함수 - N Y 두개의 버튼기능
    //N버튼 클릭시 구매창 닫고 끝
    //Y버튼 클릭시 재화가 충분한지 확인
    //재화가 충분할 경우 재화 차감 및 해당 아이템을 컬렉티드 상태로 바꾸기
    //재화가 불충분할 경우 충전창 호출

    //충전창 함수 - N Y 두개의 버튼기능
    //N버튼 클릭시 충전창 구매창 모두 끔
    //Y버튼 클릭시 충전씬으로 이동(결제관련 시스템이므로 추후 구현)
}
