using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCat : MonoBehaviour
{
    public GameObject cat1;
    public GameObject cat2;
    public GameObject cat3;
    public GameObject cat4;
    public GameObject Boss;
    void Update()
    {
        //부하 고양이 다 찾으면(비활성화되면)
        if(cat1.activeSelf == false && cat2.activeSelf == false && cat3.activeSelf == false && cat4.activeSelf == false)
        {
            Boss.gameObject.SetActive(true);
            Debug.Log("보스 등장");
        }
    }
}
