using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject spawnBloodSplatter;

    public void BloodSplatter(Vector2 position)
    {
        Instantiate(spawnBloodSplatter,position, Quaternion.identity);
    }
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
