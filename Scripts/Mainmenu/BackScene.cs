using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScene : MonoBehaviour
{
    public void BackSceneBtn()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
