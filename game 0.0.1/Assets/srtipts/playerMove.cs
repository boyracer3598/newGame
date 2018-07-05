using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {
    public Rigidbody R1;
    public float speed;
    public float force=10;
    public Ray shot;
    // Use this for initialization
    void Start () {
        R1 = GetComponent<Rigidbody>();
        R1.constraints = RigidbodyConstraints.FreezeRotationX;
        


    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Input.GetKey("space")){
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*hit.distance , Color.yellow);
            Collider other = hit.collider;
            Destroy(other.gameObject);
        }



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
