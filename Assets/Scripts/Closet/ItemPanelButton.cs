using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPanelButton : ItemStateType
{
    public void ClickPanel()    //패널을 터치했을 경우 호출
    {
        if (itemState == ItemState.Using)                               //유징상태라면 컬렉티드 상태로
        {
            Debug.Log("해제");
            itemState = ItemState.Collected;
            this.GetComponent<ItemPanelGraphicChange>().SetCollected(); //컬렉티드 그래픽체인지 함수 호출
            
            //TODO : 앨리스를 안입은 상태로 만들기 : 앨리스 스프라이트에 따로 구현
        }
        else if (itemState == ItemState.Collected)                      //컬렉티드상태라면 유징상태로
        {
            Debug.Log("착용");
            itemState = ItemState.Using;
            this.GetComponent<ItemPanelGraphicChange>().SetUsing();     //유징 그래픽체인지 함수 호출
            
            //TODO : 다른 유징상태의 패널을 컬렉티드 상태로 바꾸기
            //TODO : 앨리스 스프라이트를 해당 아이템 착용 상태로 만드는 것은 앨리스 스프라이트에 따로 구현
        }
        else                                                            //락상태라면 구매확인 창 띄우기
        {
            BuyPanel();                                                 //구매창 함수 호출
            Debug.Log("구매");
            itemState = ItemState.Collected;                            //구매시 컬렉티드 상태로
            this.GetComponent<ItemPanelGraphicChange>().SetCollected(); //컬렉티드 그래픽체인지 함수 호출
        }            
    }
        //ㄴㄴㄴㄴ buyPanel 접근방식 겟컴포넌트인페렌츠로 바꿔야함. 프리팹이라 안돼.
    void BuyPanel()             //구매창 함수 - N Y 두개의 버튼기능
    {
        buyPanel.SetActive(true);
    }
    
    public void ClickBuyButton()
    {
        buyPanel.SetActive(false);
    }

    //TODO : 
    //N버튼 클릭시 구매창 닫고 끝
    //Y버튼 클릭시 재화가 충분한지 확인
    //재화가 충분할 경우 재화 차감 및 해당 아이템을 컬렉티드 상태로 바꾸기
    //재화가 불충분할 경우 충전창 호출

    //충전창 함수 - N Y 두개의 버튼기능
    //TODO : 
    //N버튼 클릭시 충전창 구매창 모두 끔
    //Y버튼 클릭시 충전씬으로 이동(결제관련 시스템이므로 추후 구현)
}
