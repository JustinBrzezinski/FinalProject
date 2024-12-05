using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFist : MonoBehaviour
{
    private Rigidbody rb;
    public int FistSpeed = 100;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.rotation == Quaternion.Euler(0, 270, 0))
        {
            transform.position += Vector3.forward * FistSpeed * Time.deltaTime;
        }
        else if (transform.rotation == Quaternion.Euler(0, 90, 0))
        {
            transform.position += Vector3.back * FistSpeed * Time.deltaTime;
        }
        else if (transform.rotation == Quaternion.Euler(0, 180, 0))
        {
            transform.position += Vector3.left * FistSpeed * Time.deltaTime;
        }
        if (transform.rotation == Quaternion.Euler(0, 0, 0))
        {
            transform.position += Vector3.right * FistSpeed * Time.deltaTime;
        }
    }
}
