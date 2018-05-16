using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {

    Vector3 target;

    Vector3 paddlePos;
    public float speed = 5;

    Rigidbody2D rb;

    // Use this for initialization
    void Start ()
    {
        paddlePos = new Vector3(this.transform.position.x, this.transform.position.y);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Store the paddles y and z positions so they do not move
        target.z = transform.position.z;
        target.y = transform.position.y;

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);




        //float h = Input.GetAxis("Horizontal");

        //Vector3 movement = new Vector3(this.transform.position.x + h * speed * Time.deltaTime, this.transform.position.y);

        ////this.rb.AddForce(movement);
        //this.transform.position = movement;

        if(this.transform.position.x > 7.3)
        {
            this.transform.position = new Vector3(7.3f, this.transform.position.y);
        }
        else if (this.transform.position.x < -7.3)
        {
            this.transform.position = new Vector3(-7.3f, this.transform.position.y);
        }
    }
}
