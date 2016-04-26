﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
	public static int score;

	Text text;

	void Start ()
	{
		text = GetComponent<Text> ();

		score = 0;
	}

	void Update ()
	{
		if (score < 0)
			score = 0;

		text.text = "Score:" + score;

	}

	public static void AddPoints (int pointsToAdd)
	{
		score += pointsToAdd;
	}
}
