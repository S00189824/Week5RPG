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
        if(collision.gameObject.tag == "Gas")
        {
            Destroy(collision.gameObject);
            AddXP(10);

        }
        else if(collision.gameObject.tag == "Alien")
        {
            Destroy(collision.gameObject);
            GoodPoints++;
            controller.SpawnAlienBloodSplatter(collision.gameObject.transform.position);
        }
        else if(collision.gameObject.tag == "Human")
        {
            Destroy(collision.gameObject);
            BadPoints++;
            controller.SpawnBloodSplatter(collision.gameObject.transform.position);
        }
    }

    void HandleCollsion(GameObject hitObject)
    {
        string tag = hitObject.tag;
        //handle collisions
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
