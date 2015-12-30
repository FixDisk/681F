using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	bool paused = false;

	void Start () {
	
	}
	

	void Update () {

		if (Input.GetKeyDown ("escape"))
		{

			paused = togglePause ();

			Cursor.visible = true;

		}

	}

	void OnGUI()
	{

		if(paused)
		{

			GUI.Label(new Rect (Screen.width / 2 - 5, Screen.height / 3 - 5, 60, 50), "ПАУЗА !");

			if(GUI.Button(new Rect (Screen.width / 2 - 100, Screen.height / 2 - 25, 250, 50), "Продължете"))
				paused = togglePause();

			if(GUI.Button(new Rect (Screen.width / 2 - 50, Screen.height / 2 - -50, 150, 50), "Изход"))
				Application.Quit();

		}

	}

	bool togglePause()
	{

		if(Time.timeScale == 0f)
		{

			Time.timeScale = 1f;
			return(false);

		}
		else
		{

			Time.timeScale = 0f;
			return(true);

		}

	}

}
