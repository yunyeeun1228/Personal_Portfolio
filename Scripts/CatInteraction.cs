using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatInteraction : MonoBehaviour
{
    bool isOver = false;
    public GameObject talk_bubble;

    void Start()
    {
        talk_bubble.gameObject.SetActive(false);
    }
    void Update()
    {
        if(isOver && Input.GetMouseButtonDown(1)) //우클릭 이벤트
        {
            this.gameObject.SetActive(false);
            Debug.Log("고양이 획득함.");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            talk_bubble.gameObject.SetActive(true);
        }
        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            talk_bubble.gameObject.SetActive(false);
        }
    }

    void OnMouseOver()
    {
        isOver = true;
    }
    
    void OnMouseExit()
    {
        isOver = false;
    }
}
