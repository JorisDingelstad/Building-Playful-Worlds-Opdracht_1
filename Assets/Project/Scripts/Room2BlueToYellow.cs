using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2BlueToYellow : MonoBehaviour
{

    public DoorMoveYellow yellowScript;
    public DoorMoveBlue blueScript;
    public static bool BYhit = false;
    public Material[] material;
    private Renderer rend;

    // Use this for initialization
    void Start () 
    {
        yellowScript = GetComponent<DoorMoveYellow>();
        blueScript = GetComponent<DoorMoveBlue>();
        yellowScript.enabled = false;
        blueScript.enabled = true;

        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (BYhit)
        {
            yellowScript.enabled = true;
            blueScript.enabled = false;
            rend.sharedMaterial = material[1];
        }

	}
}
