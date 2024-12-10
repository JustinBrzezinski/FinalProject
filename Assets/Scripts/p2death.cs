using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2death : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HurtPunch.p2hurt == true)
        {
            if(transform.rotation == Quaternion.Euler(0, 270, 0))
            {
                transform.position += Vector3.back * GameManager.p2knockback * Sawhurt.Sawknockback;
                transform.position += Vector3.up * GameManager.p2knockback * Sawhurt.Sawknockback;
                HurtPunch.p2hurt = false;
            }
            else if (transform.rotation == Quaternion.Euler(0, 90, 0))
            {
                transform.position += Vector3.forward * GameManager.p2knockback * Sawhurt.Sawknockback;
                transform.position += Vector3.up * GameManager.p2knockback * Sawhurt.Sawknockback;
                HurtPunch.p2hurt = false;
            }
            else if (transform.rotation == Quaternion.Euler(0, 180, 0))
            {
                transform.position += Vector3.right * GameManager.p2knockback * Sawhurt.Sawknockback;
                transform.position += Vector3.up * GameManager.p2knockback * Sawhurt.Sawknockback;
                HurtPunch.p2hurt = false;
            }
            if (transform.rotation == Quaternion.Euler(0, 0, 0))
            {
                transform.position += Vector3.left * GameManager.p2knockback * Sawhurt.Sawknockback;
                transform.position += Vector3.up * GameManager.p2knockback * Sawhurt.Sawknockback;
                HurtPunch.p2hurt = false;
            }
        }
        if (GameManager.p2die == true)
        {
            Destroy(gameObject);
        }
    }
}
