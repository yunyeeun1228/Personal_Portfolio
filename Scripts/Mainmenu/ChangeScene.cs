using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "StartBtn":
                SceneManager.LoadScene("StartGame");
                break;

            case "ContiBtn":
                SceneManager.LoadScene("Continue");
                break;

            case "SetBtn":
                SceneManager.LoadScene("Settings");
                break;
        }
    }
}
