using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToBeSpawned;
    BoxCollider2D SpawnArea;
    public float elaspedTime = 0;
    public float SpawnTime = 5;
    public Vector3 RandomPosition;

	// Use this for initialization
	void Start ()
    {
        SpawnArea = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        elaspedTime += Time.deltaTime;
        if(elaspedTime > SpawnTime)
        {
            SpawnObject();
            elaspedTime = 0;
        }
	}
    void PickPosition()
    {
        float Num1 = Random.Range(SpawnArea.bounds.min.x, SpawnArea.bounds.max.x);
        float Num2 = Random.Range(SpawnArea.bounds.min.y, SpawnArea.bounds.max.y);
        RandomPosition.x = Num1;
        RandomPosition.y = Num2;
    }
    void SpawnObject()
    {
        Instantiate(ObjectToBeSpawned, RandomPosition, Quaternion.identity);
    }
}
