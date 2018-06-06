using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {

    Vector3 target;

    Vector3 paddlePos;
    public float speed = 5;

    Rigidbody2D rb;

    public bool autoPlay = false;

    private ball Ball;

    // Use this for initialization
    void Start ()
    {
        paddlePos = new Vector3(this.transform.position.x, this.transform.position.y);
        rb = GetComponent<Rigidbody2D>();

        Ball = FindObjectOfType<ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!autoPlay)
            MoveWithMouse();
        else
            AutoPlay();
    }

    void MoveWithMouse()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Store the paddles y and z positions so they do not move
        target.z = transform.position.z;
        target.y = transform.position.y;

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (this.transform.position.x > 7.3)
        {
            this.transform.position = new Vector3(7.3f, this.transform.position.y);
        }
        else if (this.transform.position.x < -7.3)
        {
            this.transform.position = new Vector3(-7.3f, this.transform.position.y);
        }
    }

    void AutoPlay()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        Vector3 ballPos = Ball.transform.position;
        paddlePos.x = ballPos.x;
        this.transform.position = paddlePos;
    }
}
