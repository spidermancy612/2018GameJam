using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetAmmoWall : MonoBehaviour {

    public bool isNewScene;
    public string sceneName;
    public GameObject playerCamera;
    public GameObject wall;
    public int newLightAmmo;
    public int newSoundAmmo;

    //////////////////////////////////////////////////////////////////////////////////////////////
    private void Start()
    {
        if(wall != null)
        wall.SetActive(false);
    }

    //////////////////////////////////////////////////////////////////////////////////////////////

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
        {
            if(isNewScene)
            {
                SceneManager.LoadScene(sceneName);
                return;
            }
            playerCamera.GetComponent<playerShoot>().setLightAmmo(newLightAmmo);
            playerCamera.GetComponent<playerShoot>().setLightAmmo(newLightAmmo);
            wall.SetActive(true);
        }
    }
}
