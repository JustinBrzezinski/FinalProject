using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartDestroy : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 1.0f);
    }
}
