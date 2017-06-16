using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    [SerializeField]
    private Canvas MainMenu;

    [SerializeField]
    private Canvas ControlMenu;

	void Awake()
    {
        ControlMenu.enabled = false;
        MainMenu.enabled = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Controls()
    {
        MainMenu.enabled = false;
        ControlMenu.enabled = true;
    }

    public void Return()
    {
        ControlMenu.enabled = false;
        MainMenu.enabled = true;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
