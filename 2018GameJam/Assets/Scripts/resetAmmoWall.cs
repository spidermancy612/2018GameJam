using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetAmmoWall : MonoBehaviour {

    public GameObject playerCamera;
    public GameObject wall;
    public int newLightAmmo;
    public int newSoundAmmo;

    private void Start()
    {
        wall.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
        {
            playerCamera.GetComponent<playerShoot>().setLightAmmo(newLightAmmo);
            playerCamera.GetComponent<playerShoot>().setLightAmmo(newLightAmmo);

            wall.SetActive(true);
        }
    }
}
