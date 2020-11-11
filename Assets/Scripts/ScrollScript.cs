using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    private float moveSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Using fixedUpdate because It doesn't allow for inconsistency on different machines, as far as I understand the Unity Community.
    void FixedUpdate()
    {
        //This script is attached to the player and the camera, so both move to the right
        //this reason the jump button isn't in the script is because I don't want the camera to jump with the player.
        transform.position += this.transform.right * moveSpeed * Time.deltaTime;
    }
}
