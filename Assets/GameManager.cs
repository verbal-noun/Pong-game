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

    }

    private void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label (new Rect( Screen.width / 2 - 100-10, 25, 100, 100), "" + playerScore1);
        GUI.Label(new Rect(Screen.width / 2 + 100-10, 25, 100, 100), "" + playerScore2);
    }
}
