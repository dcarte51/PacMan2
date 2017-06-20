using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

    public Canvas pauseMenu;

    void Awake()
    {
        Cursor.visible = false;
        pauseMenu.enabled = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.enabled = true;
            Time.timeScale = 0;
        }
        else
            Cursor.visible = false;
    }

    public void GameReturn()
    {
        pauseMenu.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
        Cursor.visible = false;
    }

    public void MenuReturn()
    {
        SceneManager.LoadScene("Menu");
    }
}
