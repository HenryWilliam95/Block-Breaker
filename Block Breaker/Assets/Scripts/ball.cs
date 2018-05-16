using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    paddle Paddle;

    private Vector3 paddleToBallVector;

    Rigidbody2D rb;
    bool started = false;

	// Use this for initialization
	void Start ()
    {
        Paddle = GameObject.FindObjectOfType<paddle>();
        paddleToBallVector = this.transform.position - Paddle.transform.position;

        rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update ()
    {
        if(!started)
            this.transform.position = Paddle.transform.position + paddleToBallVector;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            started = true;
            rb.velocity = new Vector2(2.0f, 10.0f);
        }

        
	}
}
