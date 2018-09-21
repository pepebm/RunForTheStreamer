using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed, jumpForce;
    private Rigidbody2D body;


	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        body.velocity = new Vector2(moveSpeed, body.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            body.velocity = new Vector2(body.velocity.x , jumpForce);
        }
	}
}
