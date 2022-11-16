using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text timeDisplay;
	public bool playing;
	private float time;

	void Update()
	{

		if (playing == true)
		{

			time += Time.deltaTime;
			int minutes = Mathf.FloorToInt(time / 60F);
			int seconds = Mathf.FloorToInt(time % 60F);
			int milliseconds = Mathf.FloorToInt((time * 100F) % 100F);
			timeDisplay.text = "Timer: " + minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
		}

	}
}
