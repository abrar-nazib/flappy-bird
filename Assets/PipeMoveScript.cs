using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed=8;
    private float deadZone = -32;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.left; // Time.deltaTime is the time between each frame. It is used to make the movement frame rate independent

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject); // Destroy the pipe when it goes out of the screen
        }
    }
}
