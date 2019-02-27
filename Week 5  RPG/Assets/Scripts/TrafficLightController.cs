using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TrafficLightState
{
    Red,
    Green
}
public class TrafficLightController : MonoBehaviour
{
    public TrafficLightState State;
    public float lightSwitchTime = 5;
    float elapsedTIme = 0;

    public SpriteRenderer lightConeSprite;

	// Use this for initialization
	void Start ()
    {
        SetState(TrafficLightState.Green);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void SetState(TrafficLightState newState)
    {
        
    }
}
