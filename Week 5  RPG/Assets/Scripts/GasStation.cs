using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasStation : MonoBehaviour
{
    bool hasPlayercar = false;
    public float FillRate = 2;

    float elapsedTime;
    public float fuelTimer = 5;

	// Use this for initialization
	void Start ()
    {
       
	}
    Playerdata data;
	
	// Update is called once per frame
	void Update ()
    {
        if (hasPlayercar)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= fuelTimer)
            {
                //add fuel player
                
                if(data.fuel < 100)
                {
                    data.fuel += FillRate;

                    if(data.fuel > 100.00f)
                    {
                        data.fuel = 100.00f;
                    }
                    elapsedTime = 0;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            hasPlayercar = true;
            data = collision.gameObject.GetComponent<Playerdata>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hasPlayercar = false;
            elapsedTime = 0;
            data = null;
        }
    }
}
