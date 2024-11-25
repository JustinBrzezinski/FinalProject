using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sawhurt : MonoBehaviour
{
    static public int Sawknockback = 1;
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("player2"))
        {
            GameManager.p2health -= 10;
            Sawknockback = 2;
            HurtPunch.p2hurt = true;
        }
        if (other.gameObject.CompareTag("player1"))
        {
            GameManager.p1health -= 10;
            Sawknockback = 2;
            HurtPunch.p1hurt = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Sawknockback = 1;
    }
}
