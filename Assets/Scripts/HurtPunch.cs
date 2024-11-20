using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPunch : MonoBehaviour
{
    static public bool p2hurt = false;
    static public bool p1hurt = false;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("player2"))
        {
            GameManager.p2health -= 5;
            p2hurt = true;
        }
        if (other.gameObject.CompareTag("player1"))
        {
            GameManager.p1health -= 5;
            p1hurt = true;
        }
    }
}
