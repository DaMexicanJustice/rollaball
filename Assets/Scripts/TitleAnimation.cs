using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAnimation : MonoBehaviour {

    private Vector3 movement;
    public int speed;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        movement = new Vector3(1, 0, 0);
        speed = 15;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        rb.AddForce(movement * speed);
        transform.Rotate(new Vector3(0, 0, -90) * Time.deltaTime);
    }
}
