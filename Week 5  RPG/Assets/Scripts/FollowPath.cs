using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public NavigationPath path;


    public bool canMove = true;
    public float moveSpeed = 2f;
    public float distanceToNodeToTolerence = 0.2f;
    public bool PickRandonStartNode = false;

    Vector2 currentTarget;
    Rigidbody2D body;
    public int currentNodeIndex = 0;
    

	// Use this for initialization
	void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        if(PickRandonStartNode)
        {
            currentNodeIndex = Random.Range(0, path.NodrCount - 1);
        }
        GetToNextNodePosition();
        TeleportToNode();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Vector2.Distance(transform.position,currentTarget) <= distanceToNodeToTolerence)
        {
            GetToNextNodePosition();
        }
	}

    void GetToNextNodePosition()
    {
        if (currentNodeIndex >= path.NodrCount)
        {
            currentNodeIndex = 0;
        }

        currentTarget = path.GetNodePosition(currentNodeIndex);
        transform.up = currentTarget - body.position;

        currentNodeIndex++;
    }

    void TeleportToNode()
    {
        transform.position = currentTarget;
    }

    private void FixedUpdate()
    {
        if(canMove)
        {
            body.MovePosition(Vector2.MoveTowards(transform.position, currentTarget, moveSpeed * Time.deltaTime));
        }
        body.angularVelocity = 0;
    }
}
