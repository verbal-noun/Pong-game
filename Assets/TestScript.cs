using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{


    public float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(11);
       
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
