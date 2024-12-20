using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeDmg : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (BombExplode.explode == true)
        {
            if (other.gameObject.CompareTag("player2") && BombPower.p2Bombs == false)
            {
                GameManager.p2health -= 10;
                Sawhurt.Sawknockback = 3;
                HurtPunch.p2hurt = true;
            }
            if (other.gameObject.CompareTag("player1") && BombPower.p1Bombs == false)
            {
                GameManager.p1health -= 10;
                Sawhurt.Sawknockback = 3;
                HurtPunch.p1hurt = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Sawhurt.Sawknockback = 1;
    }
}
