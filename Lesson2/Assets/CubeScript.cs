using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	public float MoveSpeed = 20;
	public float RotateSpeed = 40;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0, 1, 0);
		print (transform.position.y);
	}//Start()
	
	// Update is called once per frame
	void Update () {
		//Amount to move
		float MoveBackward = Input.GetAxis ("Vertical") * MoveSpeed * Time.deltaTime;
		float MoveLeft = Input.GetAxis ("Horizontal") * RotateSpeed * Time.deltaTime;

		//Move the Player
		transform.Translate (Vector3.back * MoveBackward);
		transform.Translate (Vector3.left * MoveLeft);
	}//Update()
}//WASDMovementScript : MonoBehaviour
