using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetAmmoWall : MonoBehaviour {

    public bool isNewScene;
    public string sceneName;
    public GameObject playerCamera;
    public GameObject door;
    public int newLightAmmo;
    public int newSoundAmmo;

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
            playerCamera.GetComponent<playerShoot>().setSoundAmmo(newSoundAmmo);
            playerCamera.GetComponent<playerShoot>().updateAnimations();
            door.GetComponent<Animator>().Play("Closing");

            this.enabled = false;
            
        }
    }
}
