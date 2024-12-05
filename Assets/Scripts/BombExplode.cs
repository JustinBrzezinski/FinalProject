using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplode : MonoBehaviour
{
    public static bool explode= false;
    public static int time = 0;
    void Update()
    {
        Debug.Log(time);
        time++;
        if (time >= 60)
        {
            explode = true;
            Debug.Log("Boom");
        }
        if (time >= 100)
        {
            time = 0;
            explode = false;
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
       
    }
}
