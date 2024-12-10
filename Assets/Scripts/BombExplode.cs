using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombExplode : MonoBehaviour
{
    public static bool explode= false;
    public static int time = 0;
    public GameObject Particles;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        time++;
        if (time >= 60)
        {
            explode = true;
        }
        if (time == 60)
        {
            Vector3 Pos = transform.position;
            Instantiate(Particles, Pos, Quaternion.identity);
        }
        if (time >= 70)
        {
            time = 0;
            explode = false;
            Destroy(gameObject);
        }
    }
}
