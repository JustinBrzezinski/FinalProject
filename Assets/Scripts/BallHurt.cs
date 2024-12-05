using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHurt : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("player2") && Invincibility.p2Immune == false)
        {
            GameManager.p2health -= 20;
            Sawhurt.Sawknockback = 5;
            HurtPunch.p2hurt = true;
        }
        if (other.gameObject.CompareTag("player1") && Invincibility.p1Immune == false)
        {
            GameManager.p1health -= 20;
            Sawhurt.Sawknockback = 5;
            HurtPunch.p1hurt = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Sawhurt.Sawknockback = 1;
    }
}
