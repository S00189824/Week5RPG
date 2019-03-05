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
    public float elapsedTIme = 0;
    GameObject player;

    public SpriteRenderer lightConeSprite;

	// Use this for initialization
	void Start ()
    {
        SetState(TrafficLightState.Green);
        lightConeSprite = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        elapsedTIme += Time.deltaTime;
		if(elapsedTIme > lightSwitchTime)
        {
            if(State == TrafficLightState.Red)
            {
                SetState(TrafficLightState.Green);
            }
            else if(State == TrafficLightState.Green)
            {
                SetState(TrafficLightState.Red);
            }
            elapsedTIme = 0;
        }
	}

    void SetState(TrafficLightState newState)
    {
        State = newState;
        if(newState == TrafficLightState.Green)
        {
            lightConeSprite.color = Color.green;
        }
        else if(newState == TrafficLightState.Red)
        {
            lightConeSprite.color = Color.red;
        }
    }
}
