using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class StageManager : MonoBehaviour
{
    [Header("Object")]
    public GameObject blueCat;
    public GameObject greenCat;
    public GameObject pinkCat;
    public GameObject yellowCat;
    public GameObject Boss;

    [Header("MiniMap")]
    public GameObject blueMap;
    public GameObject greenMap;
    public GameObject pinkMap;
    public GameObject yellowMap;
    public GameObject BossMap;

    [Header("IsChecked")]
    public bool blueChecked = false;
    public bool greenChecked = false;
    public bool pinkChecked = false;
    public bool yellowChecked = false;
    public bool All_Checked = false;

    public bool BossChecked = false;

    public static StageManager instance;

    void Start()
    {
        BossMap.gameObject.SetActive(false);
    }
    void Update()
    {
        Cat_Active();
        Cat_Checked();
        SetBoss();
    }
    void Awake()
    {
        if(instance ==null) //인스턴스가 이미 있는지 확인, 이 상태로 설정
        {
            instance = this;
        }
        else if(instance !=this) //인스턴스가 이미 있는 경우 오브젝트 제거
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject); //scene 전환해도 오브젝트가 사라지지 않음
    }

    void Cat_Active()
    {
        if(!blueCat.gameObject.activeSelf)
        {
            blueCat.gameObject.SetActive(false);
            blueMap.gameObject.SetActive(false);
            blueChecked = true;
            Debug.Log("파랑 고양이 획득.");
        }
        if(!greenCat.gameObject.activeSelf)
        {
            greenCat.gameObject.SetActive(false);
            greenMap.gameObject.SetActive(false);
            greenChecked = true;
            Debug.Log("초록 고양이 획득.");
        }
        if(!pinkCat.gameObject.activeSelf)
        {
            pinkCat.gameObject.SetActive(false);
            pinkMap.gameObject.SetActive(false);
            pinkChecked = true;
            Debug.Log("핑크 고양이 획득.");
        }
        if(!yellowCat.gameObject.activeSelf)
        {
            yellowCat.gameObject.SetActive(false);
            yellowMap.gameObject.SetActive(false);
            yellowChecked = true;
            Debug.Log("노랑 고양이 획득.");
        }
    }
    void Cat_Checked()
    {
        if(blueChecked)
        {
            Debug.Log("파랑 고양이 체크.");
        }
        if(!greenCat.gameObject.activeSelf)
        {
            Debug.Log("초록 고양이 획득.");
        }
        if(!pinkCat.gameObject.activeSelf)
        {
            Debug.Log("핑크 고양이 획득.");
        }
        if(!yellowCat.gameObject.activeSelf)
        {
            Debug.Log("노랑 고양이 획득.");
        }
        if(blueChecked&&greenChecked&&pinkChecked&&yellowChecked)
        {
            All_Checked = true;
        }
    }

    void SetBoss()
    {
        if(All_Checked)
        {
            BossChecked = true;
            BossMap.gameObject.SetActive(true);
            Boss.gameObject.SetActive(true);
            Debug.Log("보스 등장");
        }
    }
}
