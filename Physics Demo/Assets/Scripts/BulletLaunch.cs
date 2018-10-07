using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLaunch : MonoBehaviour {

	public float bulletVelocity;

	void Start () {
	}
	
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(bulletVelocity, 0, 0), ForceMode.Impulse);
        }
    }
}
