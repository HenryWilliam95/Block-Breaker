using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour {

    Vector3 paddlePos;
    public float speed = 5;

    // Use this for initialization
    void Start ()
    {
        paddlePos = new Vector3(this.transform.position.x, this.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(this.transform.position.x + h * speed * Time.deltaTime, this.transform.position.y);

        this.transform.position = movement;

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
