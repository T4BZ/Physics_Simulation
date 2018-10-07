using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour {

	Vector2 mouseLook;
	Vector2 smoothV;
	public float sensitivity = 5f;
	public float smoothing = 2f;

	GameObject player;

	void Start () {
		player = this.transform.parent.gameObject;	
	}
	
	void Update () {
		
	}
}
