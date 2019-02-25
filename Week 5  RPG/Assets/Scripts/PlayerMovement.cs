using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float vertical;
    float horizontal;

    public float Turnspeed = 2;
    public float speed = 2;

    Rigidbody2D body;
    Playerdata data;

	// Use this for initialization
	void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        data = GetComponent<Playerdata>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
	}
    void FixedUpdate()
    {
        //rotate on the Z Axis//
        transform.Rotate(0, 0, horizontal * Turnspeed);
        //transform.up stores the forward direction of the object
        body.velocity = transform.up * speed * vertical;

        //If we have, moved, subtract from fuel
        if(data.fuel >= 0)
        {
            body.velocity = transform.up * speed * vertical;
            data.fuel -= Mathf.Abs(vertical * 0.11f);
        }
        else
        {
            body.velocity = Vector2.zero;
        }
    }
}
