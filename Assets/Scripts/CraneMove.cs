using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMove : MonoBehaviour
{
    public int timer = 0;
    private Rigidbody rb;
    public int craneSpeed = 5;
    public AudioClip Move;
    void Start()
    {
        timer = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        Vector3 pos = transform.position;
        if (timer > 1500)
        {
            AudioSource.PlayClipAtPoint(Move, pos);
            transform.position += Vector3.left * craneSpeed * Time.deltaTime;
        }
        if (transform.position.x < -70)
        {
            transform.position = new Vector3(100, transform.position.y, transform.position.z);
            timer = 0;
        }
    }
}
