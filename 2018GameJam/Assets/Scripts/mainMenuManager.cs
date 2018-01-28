using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainMenuManager : MonoBehaviour {
    
    [SerializeField]
    private string sceneName = "";

    /////////////////////////////////////////////////////////////////////////////////////////////
    /*
     * Start Game Button code that launches the game scene.
     * */
    public void loadScene()
    {
        SceneManager.LoadScene(sceneName);
    }


    /////////////////////////////////////////////////////////////////////////////////////////////
    /*
     * Quit Game Button code that quits the game.
     * */
    public void QuitGame()
    {
        Application.Quit();
    }
}
