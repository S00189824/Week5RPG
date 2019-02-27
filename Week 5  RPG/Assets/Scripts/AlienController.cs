using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{
    GameObject player;
    public float RevealDistance = 5;
    SpriteRenderer sprite;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        sprite = GetComponent<SpriteRenderer>();

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector2.Distance(transform.position, player.transform.position)<= RevealDistance)
        {
            sprite.enabled = true;
        }
        else
        {
            sprite.enabled = false;
        }
	}
}
