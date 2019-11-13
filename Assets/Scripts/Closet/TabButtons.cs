using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabButtons : MonoBehaviour
{
    public ScrollRect scrollRect;       //스크롤뷰의 스크롤랙트
    public GameObject hairTabContent;
    public GameObject dressTabContent;
    public GameObject friendTabContent;
    RectTransform hairTabRectTr;
    RectTransform dressTabRectTr;
    RectTransform friendTabRectTr;
    public Button hairTab;
    public Button dressTab;
    public Button friendTab;
    Text hairTabText;
    Text dressTabText;
    Text friendTabText;
    public Color activeButtonColor = new Color(0.08627451f, 0.509804f, 0.8313726f, 1);  //열린 탭 버튼에 들어갈 색상

    void Start()
    {
        //랙트트랜스폼 컴포넌트 추출
        hairTabRectTr = hairTabContent.GetComponent<RectTransform>();
        dressTabRectTr = dressTabContent.GetComponent<RectTransform>();
        friendTabRectTr = friendTabContent.GetComponent<RectTransform>();

        //탭버튼 자식 텍스트 컴포넌트 추출
        hairTabText = hairTab.GetComponentInChildren<Text>();
        dressTabText = dressTab.GetComponentInChildren<Text>();
        friendTabText = friendTab.GetComponentInChildren<Text>();

        //ClickHairTab()의 내용으로 초기화. 애니메이션 없이 최소기능으로 빠르게 작동.
        hairTabContent.SetActive(true);
        dressTabContent.SetActive(false);
        friendTabContent.SetActive(false);
        scrollRect.content = hairTabRectTr;
        hairTab.image.color = activeButtonColor;
        dressTab.image.color = Color.white;
        friendTab.image.color = Color.white;
    }

    public void ClickHairTab()      //헤어탭 버튼 클릭시 호출
    {
        //컨텐트 활성화-비활성화
        hairTabContent.SetActive(true);
        dressTabContent.SetActive(false);
        friendTabContent.SetActive(false);

        //스크롤뷰 컨텐트 변경
        scrollRect.content = hairTabRectTr;

        //버튼 배경 색상 변경
        hairTab.image.color = activeButtonColor;
        dressTab.image.color = Color.white;
        friendTab.image.color = Color.white;

        //버튼 텍스트 색상 변경
        hairTabText.color = Color.white;
        dressTabText.color = Color.black;
        friendTabText.color = Color.black;

        //TODO : 애니메이션 넣기
    }

    public void ClickDressTab()
    {
        hairTabContent.SetActive(false);
        dressTabContent.SetActive(true);
        friendTabContent.SetActive(false);

        scrollRect.content = dressTabRectTr;

        hairTab.image.color = Color.white;
        dressTab.image.color = activeButtonColor;
        friendTab.image.color = Color.white;

        hairTabText.color = Color.black;
        dressTabText.color = Color.white;
        friendTabText.color = Color.black;
    }

    public void ClickFirendTab()
    {
        hairTabContent.SetActive(false);
        dressTabContent.SetActive(false);
        friendTabContent.SetActive(true);

        scrollRect.content = friendTabRectTr;

        hairTab.image.color = Color.white;
        dressTab.image.color = Color.white;
        friendTab.image.color = activeButtonColor;

        hairTabText.color = Color.black;
        dressTabText.color = Color.black;
        friendTabText.color = Color.white;
    }

}
