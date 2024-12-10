using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1death : MonoBehaviour
{
    void Update()
    {
        if (HurtPunch.p1hurt == true)
        {
            if (transform.rotation == Quaternion.Euler(0, 270, 0))
            {
                transform.position += Vector3.back * GameManager.p1knockback * Sawhurt.Sawknockback;
                transform.position += Vector3.up * GameManager.p1knockback * Sawhurt.Sawknockback;
                HurtPunch.p1hurt = false;
            }
            else if (transform.rotation == Quaternion.Euler(0, 90, 0))
            {
                transform.position += Vector3.forward * GameManager.p1knockback * Sawhurt.Sawknockback;
                transform.position += Vector3.up * GameManager.p1knockback * Sawhurt.Sawknockback;
                HurtPunch.p1hurt = false;
            }
            else if (transform.rotation == Quaternion.Euler(0, 180, 0))
            {
                transform.position += Vector3.right * GameManager.p1knockback * Sawhurt.Sawknockback;
                transform.position += Vector3.up * GameManager.p1knockback * Sawhurt.Sawknockback;
                HurtPunch.p1hurt = false;
            }
            if (transform.rotation == Quaternion.Euler(0, 0, 0))
            {
                transform.position += Vector3.left * GameManager.p1knockback * Sawhurt.Sawknockback;
                transform.position += Vector3.up * GameManager.p1knockback * Sawhurt.Sawknockback;
                HurtPunch.p1hurt = false;
            }
        }
        if (GameManager.p1die == true)
        {
            Destroy(gameObject);
        }
    }
}
