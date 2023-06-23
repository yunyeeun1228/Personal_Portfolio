using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviousScene : MonoBehaviour
{
    int sceneIndex;

    void Start() {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

   public void PreScene() {

    SceneManager.LoadScene(sceneIndex - 1); //이동씬 

   }

   public void MoveSceneMain() {

    SceneManager.LoadScene(sceneIndex - 2);

   }
}
