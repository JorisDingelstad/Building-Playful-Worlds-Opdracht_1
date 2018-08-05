using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2BYhit : MonoBehaviour {

    public GameObject targetToDestroy;

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bulletRed")
        {
            Room2BlueToYellow.BYhit = true;
            Destroy(targetToDestroy);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
