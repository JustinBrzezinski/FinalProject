using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketPower : MonoBehaviour
{
    public static bool p1Rocket;
    public static bool p2Rocket;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player2"))
        {
            p2Rocket = true;
        }
        if (other.gameObject.CompareTag("player1"))
        {
            p1Rocket = true;
        }
    }
}
