using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPower : MonoBehaviour
{
    public static bool p1Bombs;
    public static bool p2Bombs;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player2"))
        {
            p2Bombs = true;
        }
        if (other.gameObject.CompareTag("player1"))
        {
            p1Bombs = true;
        }
    }
}
