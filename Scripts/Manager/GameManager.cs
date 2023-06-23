using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public int playerCoin = 0;
    public int maxHealth = 10;
    public int nowHealth = 10;
    public int atkDmg = 1;
    public float speed = 5;

    public bool isPaused;

    public GameObject MenuSet;
    public GameObject pauseMenu;
    public GameObject gameOverUI;

    public static GameManager instance;

    void Start()
    {
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) { //Escape 버튼으로 설정 창 띄우기 및 정지 
            if(isPaused) {
                ResumeGame();
                if(MenuSet.activeSelf)
                    MenuSet.SetActive(false);
            }
            else
            {
                PauseGame();
                MenuSet.SetActive(true);
            }
        }
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

    public void PauseGame() { //게임 정지
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame() { //게임 재게
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void gameOver() {
        gameOverUI.SetActive(true);
    }

    public void restart() {
        gameOverUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // 게임 초기화
    }
}
