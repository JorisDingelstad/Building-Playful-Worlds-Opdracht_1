﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMoveBlue : MonoBehaviour {

    //this script has the main purpose to move a door once the gameobject that this script belongs to is hit with a bullet with the correct tag.
    //once the door has reached its destination it should return to its original destination

    public GameObject door;
    public Transform destination;
    public Transform returnDestination;
    public float speed = 7.0f;
    public float returnSpeed = 4.0f;
    private bool hit = false;
    private bool reset = false;
    public AudioSource hitSound;

    //I made this boolean because I had issues with making the bridge move from right to left. I think it had to do with the "if (door.transform.position.z <= destination.position.z)"
    //so I decided to make a boolean that I can uncheck in the inspector to ignore the <= and instead use >=
    public bool left = true;

    private void Awake()
    {
        this.gameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

    private void Update()
    {
        if (hit)
        {

            reset = false;
            float step = speed * Time.deltaTime;
            door.transform.position = Vector3.MoveTowards(door.transform.position, destination.position, step);
            this.gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            
        }


        if (left)
        {
            if (door.transform.position.z <= destination.position.z)
            {
                hit = false;
                reset = true;
            }
        }

        else
        {
            if (door.transform.position.z >= destination.position.z)
            {
                hit = false;
                reset = true;
            }
        }

        if (reset)
        {
            float step = returnSpeed * Time.deltaTime;
            door.transform.position = Vector3.MoveTowards(door.transform.position, returnDestination.position, step);
            this.gameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bulletBlue")
        {
            hitSound.Play();
            hit = true;

        }
    }
}