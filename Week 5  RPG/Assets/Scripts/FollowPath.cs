using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public NavigationPath path;

    public bool PickRandomStartNode = false;

    public bool canMove = true;
    public float moveSpeed = 2f;
    public float distanceToNodeToTolerence = 0.2f;

    Vector2 currentTarget;
    Rigidbody body;
    int current

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
