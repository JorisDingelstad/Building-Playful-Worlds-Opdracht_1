using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEmissive : MonoBehaviour {

    public Material[] materialGun;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materialGun[0];
    }

    
    void Update ()
    {
		if (fire.allowFireRed)
        {
            rend.sharedMaterial = materialGun[1];
        }

        else if (fire.allowFireBlue)
        {
            rend.sharedMaterial = materialGun[2];
        }

        else if (fire.allowFireYellow)
        {
            rend.sharedMaterial = materialGun[3];
        }

        else
        {
            rend.sharedMaterial = materialGun[0];
        }


	}
}
