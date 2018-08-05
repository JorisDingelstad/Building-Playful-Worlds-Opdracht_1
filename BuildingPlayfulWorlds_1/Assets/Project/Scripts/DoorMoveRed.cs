using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMoveRed : MonoBehaviour
{

    public GameObject door;
    public Transform destination;
    public float speed = 7.0f;
    private bool hit = false;
    public AudioSource hitSound;

    //this script has the main purpose to move a door once the gameobject that this script belongs to is hit with a bullet with the correct tag.

    private void Awake()
    {
        this.gameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

    private void Update()
    {
        if (hit)
        {


            float step = speed * Time.deltaTime;
            door.transform.position = Vector3.MoveTowards(door.transform.position, destination.position, step);
            this.gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
            
        }
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bulletRed")
        {
            hitSound.Play();
            hit = true;
        }
    }  
}
