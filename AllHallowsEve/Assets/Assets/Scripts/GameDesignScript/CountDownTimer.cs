using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour 
{
	public float timeRemaining = 162f; // The time on the counter
	public Text timeText;



	void Update ()
	{
		timeRemaining -= Time.deltaTime;
	}

	void OnGUI ()
	{
		if (timeRemaining > 0) {
			GUI.Label (new Rect (100, 20, 200, 100), "Time Remaining : " +(int)timeRemaining);  // Location of the Words and nnumbers
		}
		else 
		{
			GUI.Label (new Rect(100, 20, 200, 100), "Time's up"); // location for the Time's Up Transtion
			Application.LoadLevel(0);    // If time runs out then it will take you back to main menu
		}
	}
}
