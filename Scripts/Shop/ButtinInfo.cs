using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtinInfo : MonoBehaviour
{
    public int ItemID;
    public Text PriceText;
    public Text Quantity;
    public GameObject ShopManager;


    void Update()
    {
        PriceText.text = "Price: $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        Quantity.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();
    }
}
