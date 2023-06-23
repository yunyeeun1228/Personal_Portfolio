using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCinteraction : MonoBehaviour
{
    public GameObject shop;
    public GameObject ClickArea;
    void Start()
    {
        shop.gameObject.SetActive(false);
        ClickArea.gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            shop.gameObject.SetActive(true);
            ClickArea.gameObject.SetActive(true);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            shop.gameObject.SetActive(false);
            ClickArea.gameObject.SetActive(false);
        }
    }
}
