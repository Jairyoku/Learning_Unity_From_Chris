using UnityEngine;
using System.Collections;

public class MainCameraScript : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(1, 11, 5);
		print (transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Vector3.zero);
	}
}
