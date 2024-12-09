using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject IPower;
    public GameObject Bombpower;
    public GameObject RocketPower;
    int randNum;
    public Transform spawnDest1;
    public bool spawningbool = true;
    public float spawnTime;

    void Start()
    {
        StartCoroutine(spawning());
    }
    IEnumerator spawning()
    {
        while (spawningbool == true)
        {
            yield return new WaitForSeconds(spawnTime);
            randNum = Random.Range(1, 4);
            if (randNum == 1)
            {
                Instantiate(IPower, spawnDest1.position, spawnDest1.rotation);
            }
            if (randNum == 2)
            {
                Instantiate(Bombpower, spawnDest1.position, spawnDest1.rotation);
            }
            if (randNum == 3)
            {
                Instantiate(RocketPower, spawnDest1.position, spawnDest1.rotation);
            }
        }
    }
}
