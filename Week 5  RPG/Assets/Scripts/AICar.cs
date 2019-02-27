using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar : MonoBehaviour
{
    GameManager gamemanger;

    private void Start()
    {
        gamemanger = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HandleCollsion(collision.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HandleCollsion(collision.gameObject);
    }

    void HandleCollsion(GameObject hitObject)
    {
        string tag = hitObject.tag;
        if (tag == "Gas")
        {
            Destroy(hitObject);
            gamemanger.SpawnExplosion(hitObject.transform.position);

        }
        else if (tag == "Alien")
        {
            Destroy(hitObject);
            
            gamemanger.SpawnAlienBloodSplatter(hitObject.transform.position);
        }
        else if (tag == "Human")
        {
            Destroy(hitObject);
            gamemanger.SpawnBloodSplatter(hitObject.transform.position);
        }
    }
}
