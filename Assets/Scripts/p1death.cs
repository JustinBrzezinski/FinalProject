using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1death : MonoBehaviour
{
    void Update()
    {
        if (HurtPunch.p1hurt == true)
        {
            Debug.Log(GameManager.p1health);
            if (transform.rotation == Quaternion.Euler(0, 270, 0))
            {
                transform.position += Vector3.back * GameManager.p2knockback;
                transform.position += Vector3.up * GameManager.p2knockback;
                HurtPunch.p1hurt = false;
            }
            else if (transform.rotation == Quaternion.Euler(0, 90, 0))
            {
                transform.position += Vector3.forward * GameManager.p2knockback;
                transform.position += Vector3.up * GameManager.p2knockback;
                HurtPunch.p1hurt = false;
            }
            else if (transform.rotation == Quaternion.Euler(0, 180, 0))
            {
                transform.position += Vector3.right * GameManager.p2knockback;
                transform.position += Vector3.up * GameManager.p2knockback;
                HurtPunch.p1hurt = false;
            }
            if (transform.rotation == Quaternion.Euler(0, 0, 0))
            {
                transform.position += Vector3.left * GameManager.p2knockback;
                transform.position += Vector3.up * GameManager.p2knockback;
                HurtPunch.p1hurt = false;
            }
        }
        if (GameManager.p1die == true)
        {
            Destroy(gameObject);
        }
    }
}
