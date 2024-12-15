using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    bool isPaused = false;
    public GameObject pauseMenu;

    public GameObject player;

    public void pauseToggle(){
        isPaused = !isPaused;
        if(isPaused){
            Cursor.lockState = CursorLockMode.None;
            pauseMenu.SetActive(true);
            player.GetComponent<Look>().enabled = false;
            player.GetComponent<Move>().enabled = false;
            player.GetComponent<Jump>().enabled = false;
            Cursor.visible = true;

        } else {
            Cursor.lockState = CursorLockMode.Locked;
            pauseMenu.SetActive(false);
            player.GetComponent<Look>().enabled = true;
            player.GetComponent<Move>().enabled = true;
            player.GetComponent<Jump>().enabled = true;
            Cursor.visible = false;
        }

    }

    void Start() {
        pauseMenu.SetActive(false);
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.P)){
           pauseToggle();

        }
    }


    ///if isPaused is true, 
    ///open up the pause menu
    ///else if its false, 
    ///close the pause menu
    ///











}
