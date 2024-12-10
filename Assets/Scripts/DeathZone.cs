using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player2") || other.gameObject.CompareTag("player1"))
        {
            Destroy(other.gameObject);
            if(other.gameObject.CompareTag("player2"))
            {
                GameManager.p2health = 0;
            }
            if (other.gameObject.CompareTag("player1"))
            {
                GameManager.p1health = 0;
            }
        }
    }
}
