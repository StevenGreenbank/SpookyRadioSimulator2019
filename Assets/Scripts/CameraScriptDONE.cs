using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraScriptDONE : MonoBehaviour {

	public Camera[] Cams;
	public Camera northHallwayCam;
	public Camera southHallwayCam;
	public Camera controlRoomCam;

	public Button northHallwayButton;
	public Button southHallwayButton;
	public Button controlRoomButton;

	AudioSource staticSound;
	// Use this for initialization
	void Start () {
		staticSound = FindObjectOfType<AudioSource> ();
	}

	// Update is called once per frame
	void Update ()
	{

	}
	

	public void OnCamButtonClicks (string whichButton) {
		if(whichButton != "controlRoomButton")
			staticSound.Play ();
	
		foreach (Camera cam in Cams)
		{
			cam.depth = -10;
		}
		if (whichButton == "northHallwayButton") 
		{
			northHallwayCam.depth = 1;
		}
		else if (whichButton == "southHallwayButton") 
		{
			southHallwayCam.depth = 1;
		}
		else if (whichButton == "controlRoomButton") 
		{
			controlRoomCam.depth = 1;
		}
	}
}
