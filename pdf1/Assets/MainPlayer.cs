using UnityEngine;
using System.Collections;

public class MainPlayer: MonoBehaviour {

	// Use this for initialization
	void Start () {
		setRes(); //set screen res
		OnGUI(); //print out text box
	}//Start


	// Update is called once per frame
	void Update () {
	
	}//Update


	//set screen resolution to 700 x 200 windowed
	void setRes () {
		Screen.SetResolution (700, 200, false);
	}//setRes


	// Print out desired text
	string stringToDisplay = "The Almighty Wong Dynasty";
	void OnGUI () {
		GUI.Box (new Rect (225, 75, 250, 50), stringToDisplay);
	}//OnGUI
}//MainPlayer : MonoBehaviour
