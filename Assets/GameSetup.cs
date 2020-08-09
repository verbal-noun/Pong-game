using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    // Main Camera 
    public Camera mainCamera;

    // Walls 
    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

    public Transform player1;
    public Transform player2; 


    // Start is called before the first frame update
    void Start()
    {
        // Setting the top wall 
        this.topWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width *
            2f, 0f, 0f)).x, 1f);
        this.topWall.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f,
            Screen.height)).y + 0.5f);

        // Bottom wall 
        bottomWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(
            Screen.width * 2f, 0f, 0f)).x, 1f);
        bottomWall.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(
            0f, 0f, 0f)).y - 0.5f);

        // Left wall 
        leftWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(
            0f, Screen.height * 2f, 0f)).y);
        leftWall.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(
            0f, 0f, 0f)).x - 0.5f, 0f);

        // Right wall 
        rightWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(
            0f, Screen.height * 2f, 0f)).y);
        rightWall.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(
            Screen.width, 0f, 0f)).x + 0.5f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
