using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public KeyCode hit;
    public int punchSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(hit))
        {
            transform.position += Vector3.forward * punchSpeed;
        }
        else
        {
            
        }
    }
}
