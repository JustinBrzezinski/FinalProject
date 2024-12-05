using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idestroy : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 8);
        if (Invincibility.p1Immune == true || Invincibility.p2Immune == true)
        {
            Destroy(gameObject);
        }
        if (BombPower.p1Bombs == true || BombPower.p2Bombs == true)
        {
            Destroy(gameObject);
        }
        if (RocketPower.p1Rocket == true || RocketPower.p2Rocket == true)
        {
            Destroy(gameObject);
        }
    }
}
