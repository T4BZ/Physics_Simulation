using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 10f;

	void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update(){
		float forward = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float sideways = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		transform.Translate(sideways, 0, forward);
    
		if(Input.GetKeyDown("escape")){
			Cursor.lockState = CursorLockMode.None;
		}
	}
}
