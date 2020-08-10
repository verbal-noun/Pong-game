using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody2D rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {   
        
        rigidbody = gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;

        // Generating a random number 
        float random = Random.Range(0, 2);
        // Move the ball to a random directions 
        if (random < 0.5)
        {
            rigidbody.AddForce(new Vector2(80, 10));
        } 
        else
        {
            rigidbody.AddForce(new Vector2(-80, -10));
        }
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if(colInfo.collider.tag == "Player")
        {
            Vector3 newVelocity = GetComponent<Rigidbody2D>().velocity;
            // Calculate the new velocity my adding a mix between player's velocity 
            // and the ball's vecloty 
            newVelocity.y = rigidbody.velocity.y / 2 + 
                colInfo.collider.attachedRigidbody.velocity.y / 3;
            // Assign the new velocity to the ball 
            GetComponent<Rigidbody2D>().velocity = newVelocity;

        }
    }
}
