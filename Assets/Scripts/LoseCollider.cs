using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    [SerializeField]
    private Collider2D playerCol;


    private void OnCollisionEnter2d(Collision collision)
    {
        Debug.Log("Collision");
        if(collision.collider == playerCol)
        {
            Debug.Log("player Collision");
            Time.timeScale = 0;
            Loss();
        }
    }

    private void Loss()
    {

    }
}
