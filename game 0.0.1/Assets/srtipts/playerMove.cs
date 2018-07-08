using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {
    public Rigidbody R1;
    public float speed;
    public float force=10;
    public Ray shot;
    public Gun g1;
    // Use this for initialization
    void Start () {
        R1 = GetComponent<Rigidbody>();
        R1.constraints = RigidbodyConstraints.FreezeRotationX;
        this.g1 = gameObject.AddComponent(typeof(Gun)) as Gun;
        g1.setUp("pistal");

    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        if (Input.GetKeyUp("space")){
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, g1.range))
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*hit.distance , Color.yellow);
            Collider other = hit.collider;
            var health =other.gameObject.GetComponent<Enemy>();
            if (health.health-g1.damge <= 0){
                Destroy(other.gameObject);
            }
            else{
                health.damge(g1.damge);
                Debug.Log("health:", health);

            }

        }else if(Input.GetKeyUp("tab")){
            if(g1.gunType == "pistal"){
                g1.setUp("asult");
            }else{
                g1.setUp("pistal");
            }
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
