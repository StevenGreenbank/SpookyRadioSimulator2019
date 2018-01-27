using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public Camera[] Cams;

	public Camera ControlRoomCamera;
	public Camera NorthHallwayCamera;
	public Camera SouthHallwayCamera;

	public Button ControlRoomButton;
	public Button NorthHallwayButton;
	public Button SouthHallwayButton;

	AudioSource staticSound;

	// Use this for initialization
	void Start () {
		staticSound = FindObjectOfType<AudioSource> ();
	}
	
	public void OnCamButtonClick(string whichButton)
	{
		if(whichButton != "ControlRoomButton")
			staticSound.Play ();

		foreach (Camera cam in Cams)
			cam.depth = -10;

		if (whichButton == "ControlRoomButton")
			ControlRoomCamera.depth = 10;
		else if (whichButton == "NorthHallwayButton")
			NorthHallwayCamera.depth = 10;
		else if (whichButton == "SouthHallwayButton")
			SouthHallwayCamera.depth = 10;

	}
}
