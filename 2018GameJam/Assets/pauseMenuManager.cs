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
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Time.timeScale = 0;
            pauseCanvas.SetActive(false);
        }
        else
        {
            Time.timeScale = 1f;
            pauseCanvas.SetActive(false);
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////
    public void pauseGame()
    {
        isPaused = !isPaused;
    }
}