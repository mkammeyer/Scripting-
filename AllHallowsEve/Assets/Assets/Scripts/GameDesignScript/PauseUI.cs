using UnityEngine;
using System.Collections;

public class PauseUI : MonoBehaviour 
{
	public GameObject PanelPause;  

	private bool paused = false; // turns on and off


	void Start ()
	{
		PanelPause.SetActive (false); // Starts Off
	}

	void Update ()  // void menu ()
	{
		if(Input.GetButtonDown("Paused"))
		{
			paused = !paused;
		}

		if(paused)
		{
			PanelPause.SetActive(true); // turns the time off in the game
			Time.timeScale = 0;
		}

		if(!paused)
		{
			PanelPause.SetActive(false); // turns time back on
			Time.timeScale = 1;
		}
	}

	public void ButtonResume ()
	{
		paused = false;
	}


	public void ButtonRestart ()
	{
		Application.LoadLevel (Application.loadedLevel); // re-loads the level

	}

	public void ButtonMainMain ()
	{
		Application.LoadLevel (0); // takes you back to splash screen
	}

	public void ButtonQuit ()
	{
		Application.Quit ();
	}
}
