using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public int range;
    public int damge;
    public string gunType;
    public void setUp(string gunName){
        if (gunName == "pistal"){
            range = 50;
            damge = 100;
            gunType = "pistal";
        }else if(gunName == "asult"){
            range = 100;
            damge = 30;
            gunType = "asult";
        }
    }

    public int getRange(){
        return this.range;
    }

    public int getDamge(){
        return this.damge;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
