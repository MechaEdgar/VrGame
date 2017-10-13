using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 0.5f;
	public Vector3 castlePosition;

	private Vector3 targetPosition;

	// Use this for initialization
	void Start () {
		targetPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//Looking at the door
		RaycastHit hit;
		if(Physics.Raycast(transform.position, transform.forward, out hit)){
			//Debug.Log (hit.transform.name);
			if(hit.transform.GetComponent<DoorButton> () != null){
				//Debug.Log ("Looked at door button!");
				hit.transform.GetComponent<DoorButton> ().OnLook ();
				MoveToCastle();
			}
		}

		//shooting at enemies


		//Moving Logic that doesnt work...yet.
		transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
	}
	private void MoveToCastle(){
		targetPosition = castlePosition;
	}
}
