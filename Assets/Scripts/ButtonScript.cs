using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void quitButton(){
        Application.Quit();
    }

    public void loadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
