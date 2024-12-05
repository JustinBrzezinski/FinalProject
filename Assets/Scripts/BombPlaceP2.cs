using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPlacep2 : MonoBehaviour
{
    public KeyCode place;
    public GameObject bombs;
    private Rigidbody rb;
    public GameObject Rocket;
    public int bombtotal = 0;
    public Transform spawnDest1;
    public Vector3 spawnpoint;
    public int offsetz = 0;
    public int offsetx = 0;
    void Start()
    {
        bombtotal = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation == Quaternion.Euler(0, 270, 0))
        {
            offsetz = 5;
            offsetx = 0;
        }
        else if (transform.rotation == Quaternion.Euler(0, 90, 0))
        {
            offsetz = -5;
            offsetx = 0;
        }
        else if (transform.rotation == Quaternion.Euler(0, 180, 0))
        {
            offsetx = -5;
            offsetz = 0;
        }
        if (transform.rotation == Quaternion.Euler(0, 0, 0))
        {
            offsetx = 5;
            offsetz = 0;
        }
        spawnpoint = new Vector3(transform.position.x + offsetx, transform.position.y, transform.position.z + offsetz);
        if (BombPower.p2Bombs == true)
        {
            if (Input.GetKeyDown(place))
            {
                BombExplode.time = 0;
                Instantiate(bombs, spawnpoint, spawnDest1.rotation);
                bombtotal++;
            }
            if (bombtotal == 5)
            {
                BombPower.p2Bombs = false;
                bombtotal = 0;
            }
        }
        if (RocketPower.p2Rocket == true)
        {
            if (Input.GetKeyDown(place))
            {
                Instantiate(Rocket, spawnpoint, spawnDest1.rotation);
                bombtotal++;
            }
            if (bombtotal == 1)
            {
                RocketPower.p2Rocket = false;
                bombtotal = 0;
            }
        }
    }
}
