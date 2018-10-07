using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public bool isCarrying = false;
    Rigidbody rigidbody;
    public float riseSpeed = 5f;

    RigidbodyConstraints originalConstraints;


    void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
        originalConstraints = rigidbody.constraints;
    }
	
	void Update ()
    {
        if (isCarrying)
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 1, Camera.main.ScreenToWorldPoint(Input.mousePosition).z);
            rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;
        }
        else
        {
             rigidbody.constraints = originalConstraints;
        }
    }
}
