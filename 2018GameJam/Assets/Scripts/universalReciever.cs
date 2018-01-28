using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class universalReciever : MonoBehaviour {

    private bool lightActive;
    private bool soundActive;

    private bool soundChanged;
    private bool lightChanged;

    private int soundTimer;
    private int lightTimer;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public void updateLight ()
    {
        lightActive = !lightActive;
        lightTimer = 2;
        lightChanged = true;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public void updateSound ()
    {
        soundActive = !soundActive;
        soundTimer = 2;
        soundChanged = false;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool getLight ()
    {
        return lightActive;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool recentSoundChange ()
    {
        return soundChanged;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool recentLightChange ()
    {
        return lightChanged;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool getSound ()
    {
        return soundActive;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    private void Update()
    {
        if (soundTimer > 0)
        {
            soundTimer--;
        }
        else
        {
            soundChanged = false;
        }

        if (lightTimer > 0)
        {
            lightTimer--;
        }
        else
        {
            lightChanged = false;
        }
    }
}
