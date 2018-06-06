using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public static int breakableBricks = 0;

    public Sprite[] sprites;

    private int timesHit;
    private bool isBreakable;

    GameManager gameManager;

	// Use this for initialization
	void Start ()
    {
        timesHit = 0;
        gameManager = FindObjectOfType<GameManager>();

        isBreakable = (this.tag == "Breakable");

        if (isBreakable)
        {
            breakableBricks++;
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBreakable)
        {
            HandleHits(collision);
        }
    }

    void HandleHits(Collision2D collision)
    {
        int maxHits = sprites.Length + 1;

        if (collision.gameObject.tag == "Player")
        {
            timesHit++;
        }

        if (timesHit >= maxHits)
        {
            breakableBricks--;
            gameManager.BrickDestroyed();
            Destroy(gameObject);
        }
        else
        {
            LoadSprites();
        }
    }

    void LoadSprites()
    {
        int spriteIndex = timesHit - 1;

        if (sprites[spriteIndex] != null)
        {
            this.GetComponent<SpriteRenderer>().sprite = sprites[spriteIndex];
        }
        else
        {
            Debug.LogError("Sprite does not exist at index: " + spriteIndex);
        }
    }
}
