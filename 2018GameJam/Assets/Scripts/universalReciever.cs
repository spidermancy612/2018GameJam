using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class universalReciever : MonoBehaviour {

    private bool lightActive;
    private bool soundActive;

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public void updateLight ()
    {
        lightActive = !lightActive;
        Debug.Log("Changing Light");
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public void updateSound ()
    {
        soundActive = !soundActive;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool getLight ()
    {
        return lightActive;
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////
    public bool getSound ()
    {
        return soundActive;
    }

    private void Update()
    {
        //Debug.Log(lightActive);
    }
}
