using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Delete : MonoBehaviour {

    private GameObject unitychan;
    //private float difference;
    

	// Use this for initialization
	void Start () {
        this.unitychan = GameObject.Find("unitychan");
        //this.difference = unitychan.transform.position.z - gameObject.transform.position.z;


	}
	
	// Update is called once per frame
	void Update() {
        if (unitychan.transform.position.z-10 > gameObject.transform.position.z)
        {
            Destroy(this.gameObject);
        }
	}
}
