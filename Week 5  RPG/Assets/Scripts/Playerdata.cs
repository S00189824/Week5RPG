using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdata : MonoBehaviour
{
    public float fuel = 100;
    public float cash = 100;
    public int XP;
    public int Level = 1;
    public int GoodPoints = 0;
    public int BadPoints = 0;
    public int Health = 100;
    public int Ammo = 100;
    public int XpTolevel = 10;
    public GameManager controller;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HandleCollsion(collision.gameObject); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HandleCollsion(collision.gameObject);
    }

    void HandleCollsion(GameObject hitObject)
    {
        string tag = hitObject.tag;
        if (tag == "Gas")
        {
            Destroy(hitObject);
            AddXP(10);
            controller.SpawnExplosion(hitObject.transform.position);
        }
        else if (tag == "Alien")
        {
            Destroy(hitObject);
            GoodPoints++;
            controller.SpawnAlienBloodSplatter(hitObject.transform.position);
        }
        else if (tag == "Human")
        {
            Destroy(hitObject);
            BadPoints++;
            controller.SpawnBloodSplatter(hitObject.transform.position);
        }
    }

    public void AddXP(int amount)
    {
        XP += amount;
        CheckifLvLed();
    }

    void CheckifLvLed()
    {
        if(XP >= XpTolevel)
        {
            XP = 0;
            Level++;
            XpTolevel *= Level;
        }
    }
}
