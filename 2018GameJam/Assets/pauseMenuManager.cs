using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuManager : MonoBehaviour {

    private bool isPaused;

    public GameObject pauseCanvas;

    /////////////////////////////////////////////////////////////////////////////////////////
    void Start () {
        pauseCanvas.SetActive(false);
	}

    /////////////////////////////////////////////////////////////////////////////////////////
    void Update () {
        if (Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 0f;
            pauseCanvas.SetActive(true);

            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////
    public void resumeGame()
    {
        Time.timeScale = 1f;
        pauseCanvas.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}