using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerShoot : MonoBehaviour {

    public int defaultAmmo;
    public bool infiniteAmmo;

    public int maxSoundAmmo;
    public int maxLightAmmo;

    public GameObject ammoCounterGUI;
    private Text ammoText;

    private int lightAmmo;
    private int soundAmmo;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //Method called once at start of scene
    private void Start()
    {
        ammoText = ammoCounterGUI.GetComponent<Text>();

        lightAmmo = defaultAmmo;
        soundAmmo = defaultAmmo;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //Method called every frame to update player inputs
    void Update () {
        checkPlayerInput();
        updateAmmoGUI();
        if (infiniteAmmo)
        {
            soundAmmo = 1;
            lightAmmo = 1;
        }
	}

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //Method called by update every frame tp update ammo GUI
    private void updateAmmoGUI ()
    {
        ammoText.text = lightAmmo.ToString() + " / " + soundAmmo.ToString();
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //Method checks for user input when pressing the mouse keys
    private void checkPlayerInput ()
    {
        //left click - for lights
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.collider.tag == "light")
                {
                    Debug.Log("Hit Light");
                    applyLight(hit.collider.gameObject.GetComponent<universalReciever>());
                }
            }
        }

        //right click - for sounds
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.collider.tag == "sound")
                {
                    Debug.Log("Hit Sound");
                    applySound(hit.collider.gameObject.GetComponent<universalReciever>());
                }
            }
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //Called when the player raycasts to an object tagged as "light"
    private void applyLight(universalReciever reciever)
    {
        if (reciever.getLight() == true && lightAmmo < maxLightAmmo) 
        {
            reciever.updateLight();
            lightAmmo++;
        }
        else if (reciever.getLight() == false && lightAmmo > 0)
        {
            reciever.updateLight();
            lightAmmo--;
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //Called when the player raycasts to an object tagged as "sound"
    private void applySound (universalReciever reciever)
    {
        if (reciever == null)
            Debug.Log("test");
        if (reciever.getSound())
        {
            if (soundAmmo < maxSoundAmmo)
            {
                reciever.updateSound();
                soundAmmo++;
            }
        }
        else
        {
            if (soundAmmo > 0)
            {
                reciever.updateSound();
                soundAmmo--;
            }
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    public void setLightAmmo (int ammo)
    {
        lightAmmo = ammo;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    //
    public void setSoundAmmo (int ammo)
    {
        soundAmmo = ammo;
    }
}
