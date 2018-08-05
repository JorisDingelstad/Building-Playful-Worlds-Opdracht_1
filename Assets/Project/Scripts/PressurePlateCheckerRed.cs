using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateCheckerRed : MonoBehaviour {

    public GameObject buttonRed;

    private void Awake()
    {
        
        buttonRed.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

    //the OnTriggerEnter en -Exit contain code to set the allowFire variables in the fire to true or false, depending on whether or not the player is standing on the trigger collider
    //they also contain code to make the button's material activate its emission.
    private void OnTriggerEnter(Collider other)
    {

        fire.allowFireRed = true;
        buttonRed.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");

    }

    private void OnTriggerExit(Collider other)
    {

        fire.allowFireRed = false;
        buttonRed.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

    }
}
