using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int playerScore1;
    static int playerScore2; 

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
}
