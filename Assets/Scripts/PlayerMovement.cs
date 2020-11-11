using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Vector3 jump;
    public float jumpForce = 2.0f;

    public Collider2D backCol;
    public Collider2D bottomCol;
    public Collider2D winCol;
    public GameObject canvas;

    string mainMenuScene = "MainMenu";

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    { 
         if(Input.GetKeyDown(KeyCode.Space))
         {
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
         }
          
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        //if the player collides with the set barricades behind and below them the game stops and the lose thing plays out.
        if (collider == backCol || collider == bottomCol)
        {
            Loss();
        }
        else if(collider == winCol)
        {
            Win();
        }
    }

    public void Loss()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    public void Win()
    {
        canvas.SetActive(true);
    }
}
