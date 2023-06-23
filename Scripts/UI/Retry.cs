using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("다시시작");
        GameManager.instance.nowHealth = GameManager.instance.maxHealth;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // 게임 초기화
    }
}
