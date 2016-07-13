using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {
	public Texture2D crosshairTexture; 
	public Rect position; 
	static bool OriginalOn = true;

	void Start() 
	{
		position = new Rect((Screen.width - crosshairTexture.width) / 2, (Screen.height - crosshairTexture.height) /2, crosshairTexture.width, crosshairTexture.height);
	}

	void OnGUI() 
	{
		//Screen.lockCursor = true; 
		// Debug.Log(Cursor.lockState);
		// Cursor.lockState = CursorLockMode.Locked;
		// Cursor.visible = false;
		// Screen.showCursor = false; 

		if(OriginalOn == true) 
			GUI.DrawTexture(position, crosshairTexture); 
	}
}
