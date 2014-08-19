using UnityEngine;
using System.Collections;

public class SpotlightScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0, 15, 0);
		print (transform.position.y);
	}//Start()


	// Update is called once per frame
	void Update () {
		//intentionally empty
	}//Update()

}//SpotlightScript : MonoBehaviour
