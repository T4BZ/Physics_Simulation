using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement2D : MonoBehaviour {

	public float speed = 5f;
    RaycastHit hit;

    void Start ()
    {
		
	}
	
	void Update ()
    {
		transform.Translate (Input.GetAxis("Horizontal")*speed*Time.deltaTime,Input.GetAxis("Vertical")*speed*Time.deltaTime, 0);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100f))
            {
                if (hit.transform.GetComponent<Interactable>() != null)
                {
                    Debug.Log(hit.transform.name + " hit");
                    Interactable interactable = hit.transform.GetComponent<Interactable>();
                    interactable.isCarrying = true;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (hit.transform.GetComponent<Interactable>() != null) { 
                Interactable interactable = hit.transform.GetComponent<Interactable>();
                interactable.isCarrying = false;
            }
        }
    }
}
