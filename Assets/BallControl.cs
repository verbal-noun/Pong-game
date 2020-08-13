using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float ballSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {   
        // Getting the ball's component 
        rigidbody = gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;

        // Shoot the ball 
        StartCoroutine(ShootBall());
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

    // Wrapper function to shoot the ball with delay time 
    IEnumerator ShootBall()
    {
        yield return new WaitForSeconds(2);
        GoBall();
    }

    // A function to shoot the ball at a random direction 
    void GoBall()
    {

        // Generating a random number 
        float random = Random.Range(0, 2);
        // Move the ball to a random directions 
        if (random < 0.5)
        {
            rigidbody.AddForce(new Vector2(ballSpeed, 10));
        }
        else
        {
            rigidbody.AddForce(new Vector2(-ballSpeed, -10));
        }
    }

    // Function to reset the position of the ball
    IEnumerator ResetBall()
    {
        rigidbody.velocity = new Vector2(0.0f, 0.0f);
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        yield return new WaitForSeconds(1f);
        GoBall();
    }
}
