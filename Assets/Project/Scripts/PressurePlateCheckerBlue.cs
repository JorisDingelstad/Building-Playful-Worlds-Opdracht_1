using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateCheckerBlue : MonoBehaviour {

    public GameObject buttonBlue;

    private void Awake()
    {
        buttonBlue.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

    //the OnTriggerEnter en -Exit contain code to set the allowFire variables in the fire to true or false, depending on whether or not the player is standing on the trigger collider
    //they also contain code to make the button's material activate its emission.
    private void OnTriggerEnter(Collider other)
    {

        fire.allowFireBlue = true;
        buttonBlue.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }

    private void OnTriggerExit(Collider other)
    {

        fire.allowFireBlue = false;
        buttonBlue.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

    }
}
