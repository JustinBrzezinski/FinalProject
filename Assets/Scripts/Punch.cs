using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public KeyCode hit;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(hit))
        {
            anim.SetTrigger("Input");
            anim.SetTrigger("Input2");
        }
    }
}
