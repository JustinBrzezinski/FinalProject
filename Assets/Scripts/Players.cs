using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float moveSpeed  =   2.0f;
    public float jumpSpeed  =   2.0f;
    public float DashDistance = 1.5f;
    private Rigidbody rb;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;
    public KeyCode Jump;
    public KeyCode dash;
    public bool IsGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(up))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 270, 0);
            if (Input.GetKey(left))
            {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(right))
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
            if(Input.GetKeyDown(dash))
            {
                transform.position += Vector3.forward * DashDistance;
            }
        }
        else if(Input.GetKey (down))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 90, 0);
            if (Input.GetKey(left))
            {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(right))
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKeyDown(dash))
            {
                transform.position += Vector3.back * DashDistance;
            }
        }
        else if(Input.GetKey(left))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            if (Input.GetKey(up))
            {
                transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(down))
            {
                transform.position += Vector3.back * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKeyDown(dash))
            {
                transform.position += Vector3.left * DashDistance;
            }
        }
        else if(Input.GetKey(right))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            if (Input.GetKey(up))
            {
                transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(down))
            {
                transform.position += Vector3.back * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKeyDown(dash))
            {
                transform.position += Vector3.right * DashDistance;
            }
        }
        if(Input.GetKeyDown(Jump) && IsGrounded)
        {
            transform.position += Vector3.up * jumpSpeed * Time.deltaTime;
        }
    }
    void OnCollisionEnter(Collision other)
    {
            IsGrounded = true;
    }
    void OnCollisionExit(Collision other)
    {
            IsGrounded = false;
    }
}
