using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdata : MonoBehaviour
{
    public float fuel = 100;
    public float cash = 100;
    public int XP;
    public int Level = 1;
    public int GoodPoints;
    public int BadPoints;
    public int Health = 100;
    public int Ammo = 100;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Gas")
        {
            Destroy(gameObject);
        }
    }

    void HandleCollsion(GameObject hitObject)
    {
        string tag = hitObject.tag;
        //handle collisions
    }
}
