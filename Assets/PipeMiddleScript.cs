using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic; // Reference to the logic script
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // Find the logic game object and get the logic script component
        // Debug to see logic is not null
     }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) // When the player collides with the pipe
    {
        if(collision.gameObject.layer == 3)
            logic.updateScore(); // Call the update score function from the logic script (which is attached to the logic game object)
    }
    
}
