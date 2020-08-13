using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int playerScore1 = 0;
    static int playerScore2 = 0;

    public GUISkin skin; 

    public static void Score(string wallname)
    {
        if(wallname == "RightWall")
        {
            playerScore1 += 1;
        }
        else
        {
            playerScore2 += 1;
        }

        Debug.Log("Player 1:" + playerScore1);
        Debug.Log("Player 2:" + playerScore2);
    }

    private void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label (new Rect( Screen.width / 2 - 150, 25, 100, 100), "" + playerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 150, 25, 100, 100), "" + playerScore2);
    }
}
