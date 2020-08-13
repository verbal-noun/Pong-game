using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        
        if(hitInfo.name == "Ball")
        {
            GameManager.Score(transform.name);
            hitInfo.gameObject.SendMessage("ResetBall");
        }
    }
}
