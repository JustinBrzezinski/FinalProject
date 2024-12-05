using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    public static bool p1Immune = false;
    public static bool p2Immune = false;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("player2"))
        {
            p2Immune = true;
        }
        if (other.gameObject.CompareTag("player1"))
        {
            p1Immune = true;
        }
    }
}
