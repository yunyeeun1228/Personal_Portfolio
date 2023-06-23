using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
    public Text coinText;

    void Start()
    {
        coinText = GetComponent<Text>();
    }

    void Update()
    {
        coinText.text = "X " + GameManager.instance.playerCoin.ToString();
    }
}
