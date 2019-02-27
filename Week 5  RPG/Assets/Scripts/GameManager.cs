using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject BloodSplatter;
    public GameObject Explosion;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SpawnBloodSplatter(Vector2 position)
    {
        Instantiate(BloodSplatter, position, Quaternion.identity);
    }

    public void SpawnBloodSplatter(Vector2 position, Color bloodcolor)
    {
        //Spawn an Object,keep the spawned object in the local variable
        GameObject blood = Instantiate(BloodSplatter, position, Quaternion.identity);
        SpriteRenderer sprite = blood.GetComponent<SpriteRenderer>();
        sprite.color = bloodcolor;
    }

    public void SpawnAlienBloodSplatter(Vector2 position)
    {
        SpawnBloodSplatter(position, Color.black);
    }

    public void SpawnExplosion(Vector2 position)
    {
        Instantiate(Explosion, position, Quaternion.identity);
    }
}
