using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHits;
    public int timesHit;

    GameManager gameManager;

	// Use this for initialization
	void Start ()
    {
        timesHit = 0;
        gameManager = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
            timesHit++;

        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
        }

        // TODO Remove when adding real win functionalliy
       // SimulateWin();
    }

    private void SimulateWin()
    {
        gameManager.LoadNextLevel();
    }
}
