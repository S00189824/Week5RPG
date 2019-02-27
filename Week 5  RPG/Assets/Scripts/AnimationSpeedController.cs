﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController : MonoBehaviour
{
    Animator animator;
    public float PlaybackSpeed = 1.0f;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
        animator.speed = PlaybackSpeed;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
