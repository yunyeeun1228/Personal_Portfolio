using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatHead : MonoBehaviour
{
    [Header("Head")]
    public GameObject blueHead;
    public GameObject greenHead;
    public GameObject pinkHead;
    public GameObject yellowHead;

    void Update() {
        if(StageManager.instance.blueChecked == true)
        {
            blueHead.gameObject.SetActive(true);
            Debug.Log("파란고양이 체크됨.");
        }
        if(StageManager.instance.greenChecked == true)
        {
            greenHead.gameObject.SetActive(true);
            Debug.Log("파란고양이 체크됨.");
        }
        if(StageManager.instance.pinkChecked == true)
        {
            pinkHead.gameObject.SetActive(true);
            Debug.Log("파란고양이 체크됨.");
        }
        if(StageManager.instance.yellowChecked == true)
        {
            yellowHead.gameObject.SetActive(true);
            Debug.Log("파란고양이 체크됨.");
        }
    }
}
