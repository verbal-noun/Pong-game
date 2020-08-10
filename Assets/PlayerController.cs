using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode moveUp;
    public KeyCode moveDown;
    float speed = 10f;

    Rigidbody2D rigidBody;

    // Instantiating objects 
    private void Awake()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(moveUp))
        {
           
            rigidBody.velocity = new Vector2(0.0f, speed);
        }
        else if(Input.GetKey(moveDown))
        {
            rigidBody.velocity = new Vector2(0.0f, -speed);
        } 
        else
        // Stop player when key is not pressed 
        {
            rigidBody.velocity = new Vector2(0.0f, 0.0f);
        }

    }
}
