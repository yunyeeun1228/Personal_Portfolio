using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreItemInteraction : MonoBehaviour
{
    [SerializeField] GameObject pickUpKey;
    bool isPickup;

    void Start()
    {
        pickUpKey.gameObject.SetActive(false);
    }

    void Update()
    {
        if(isPickup && Input.GetKeyDown(KeyCode.E))
        {
            //아이템 적용 함수 필요
            PickUp(); //아이템 구매하면 상점에서 없애기
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            pickUpKey.gameObject.SetActive(true);
            isPickup = true; //구매를 할 수 있는 상태true로 전환
        }
    }

        void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            pickUpKey.gameObject.SetActive(false);
            isPickup = false;
        }
    }

    void PickUp()
    {
        Destroy(gameObject);
    }
}