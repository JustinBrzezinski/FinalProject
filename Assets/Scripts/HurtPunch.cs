using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPunch : MonoBehaviour
{
    static public bool p2hurt = false;
    static public bool p1hurt = false;
    public GameObject HitSpark;
    public AudioClip hit;
    void OnTriggerEnter(Collider other)
    {
        Vector3 pos = other.transform.position;
        AudioSource.PlayClipAtPoint(hit, pos);
        if (other.gameObject.CompareTag("player2") && Invincibility.p2Immune == false)
        {
            GameManager.p2health -= 5;
            p2hurt = true;
            Vector3 contact = other.transform.position;
            Instantiate(HitSpark, contact, Quaternion.identity);
        }
        if (other.gameObject.CompareTag("player1") && Invincibility.p1Immune == false)
        {
            GameManager.p1health -= 5;
            p1hurt = true;
            Vector3 contact = other.transform.position;
            Instantiate(HitSpark, contact, Quaternion.identity);
        }
    }
}
