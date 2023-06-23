using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public int Coin = 0;
    public int maxHp = 100;
    public int nowHp = 100;

    public static UIManager instance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if(instance ==null)
        {
            instance = this;
        }
        else if(instance !=this)
        {
            Destroy(gameObject);
        }
    }
}
