using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    bool isOver = false;
    public GameObject can_bubble;
    public GameObject cant_stella_bubble;
    public GameObject cant_health_bubble;
    public GameObject can_after_bubble;
    public GameObject heartItemPrefab;

    void Start()
    {
        can_bubble.SetActive(true);
        cant_stella_bubble.SetActive(false);
        cant_health_bubble.SetActive(false);
        can_after_bubble.SetActive(false);
    }
    void Update()
    {
        if(isOver && Input.GetMouseButtonDown(1)) //우클릭 이벤트
        {
            if(GameManager.instance.playerCoin>=5 && GameManager.instance.nowHealth < GameManager.instance.maxHealth)
            {
                
                GameManager.instance.playerCoin -= 5;
                
                // 하트 아이템 생성
                GameObject heartItem = Instantiate(heartItemPrefab, new Vector3(-10.57f, 25.11f, 0f), Quaternion.identity);
                
                if (GameManager.instance.nowHealth > GameManager.instance.maxHealth)
                {
                    GameManager.instance.nowHealth = GameManager.instance.maxHealth;
                }
                AfterPurchase();
                Invoke("CanPurchase", 1.5f);
                Debug.Log("정상 구매함");
            }
            else if(GameManager.instance.nowHealth >= GameManager.instance.maxHealth)
            {
                CantPurchase_fullHealth();
                Invoke("CanPurchase", 1.5f);
                Debug.Log("풀피. 구매할 수 없음");
            }
            else
            {
                CantPurchase_Stella();
                Invoke("CanPurchase", 1.5f);
                Debug.Log("스텔라 부족. 구매할 수 없음");
            }
        }
        // if(isOver && Input.GetMouseButtonDown(0))//좌클릭 이벤트
        // {
        //     
        // }
    }
    
    void OnMouseOver()
    {
        isOver = true;
    }
    
    void OnMouseExit()
    {
        isOver = false;
    }
    
    void CantPurchase_Stella()
    {
        can_bubble.SetActive(false);
        cant_stella_bubble.SetActive(true);
    }
    void CantPurchase_fullHealth()
    {
        can_bubble.SetActive(false);
        cant_health_bubble.SetActive(true);
    }
    void CanPurchase()
    {
        can_bubble.SetActive(true);
        cant_stella_bubble.SetActive(false);
        cant_health_bubble.SetActive(false);
        can_after_bubble.SetActive(false);
    }
    void AfterPurchase()
    {
        can_bubble.SetActive(false);
        can_after_bubble.SetActive(true);
    }
}