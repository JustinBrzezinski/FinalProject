using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public float p1health = 100;
    static public float p2health = 100;
    static public bool p1die = false;
    static public bool p2die = false;
    static public float p1knockback;
    static public float p2knockback;
    public int timer = 0;
    public GameObject p1;
    public GameObject p2;
    // Start is called before the first frame update
    void Start()
    {
        startGame();
    }

    // Update is called once per frame
    void Update()
    {
        if(p1health <= 0)
        {
            p1die = true;
        }
        if(p2health <= 0)
        {
            p2die = true;
        }
        p1knockback = (-1 * (p1health - 100)) / 3;
        p2knockback = (-1 * (p2health -100)) / 3;

    }
    private void FixedUpdate()
    {
        if (Invincibility.p1Immune == true || Invincibility.p2Immune == true)
        {
            timer++;
            if (timer >= 360)
            {
                Invincibility.p1Immune = false;
                Invincibility.p2Immune = false;
                timer = 0;
            }
        }
    }
    public void startGame()
    {
        p1health = 100;
        p2health = 100;
        p1die=false;
        p2die=false;
    }
}
