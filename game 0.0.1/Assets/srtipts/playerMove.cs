using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {
    public Rigidbody R1;
    public float speed;
    public float force=10;
	// Use this for initialization
	void Start () {
        R1 = GetComponent<Rigidbody>();
        R1.constraints = RigidbodyConstraints.FreezeRotationX;


    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up")){
            speed = 1;
        }else if (Input.GetKey("down")){
            speed = -1;
        }else {
            speed = 0;
        }
        R1.AddForce(transform.forward * speed *force);
	}
}
