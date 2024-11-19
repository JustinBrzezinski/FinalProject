using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    public float moveSpeed  =   2.0f;
    public float jumpSpeed  =   2.0f;

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
            if (Input.GetKey(left))
            {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(right))
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
        }
        else if(Input.GetKey (down))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
            if (Input.GetKey(left))
            {
                transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(right))
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }
        }
        else if(Input.GetKey(left))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            if (Input.GetKey(up))
            {
                transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(down))
            {
                transform.position += Vector3.back * moveSpeed * Time.deltaTime;
            }
        }
        else if(Input.GetKey(right))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            if (Input.GetKey(up))
            {
                transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
            }
            if (Input.GetKey(down))
            {
                transform.position += Vector3.back * moveSpeed * Time.deltaTime;
            }
        }
        if(Input.GetKeyDown(Jump) && IsGrounded)
        {
            transform.position += Vector3.up * jumpSpeed * Time.deltaTime;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("Enter");
            IsGrounded = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("Exit");
            IsGrounded = false;
        }
    }
}
