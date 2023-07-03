using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Public variables are visible in the inspector
    public Rigidbody2D myRigidBody;
    public float flapStrength = 12;
    public LogicScript logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        // These codes will run as soon as the script is enabled
        // It only runs once 
        myRigidBody.gravityScale = 2;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Update runs constantly once the script is enabled
        
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
            myRigidBody.velocity = Vector2.up * flapStrength;  // Give upward velocity to the bird
        
        // Game over if bird goes out of the screen
        if (transform.position.y > 15 || transform.position.y < -15)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When the bird collides with something
        logic.gameOver(); // Call the game over function from the logic script
        birdIsAlive = false;
    }
}
