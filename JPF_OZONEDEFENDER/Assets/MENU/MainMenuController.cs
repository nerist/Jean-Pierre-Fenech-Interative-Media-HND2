using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

		public GUISkin style;
		public GUISkin style2;
		
		//18. added GUI to menu controller
		void OnGUI()
		{
			//21.Add the skin to the GUI
			GUI.skin = style;
			
			
				//25. Load the main game
			if (GUI.Button (new Rect (Screen.width / 2 - 60f, Screen.height / 2 + 10f, 110f, 50f), "START GAME")) {
			//26. Load the main screne which is 1 in the BUILD SETTINGS
			Application.LoadLevel (1);
		}

		if (GUI.Button (new Rect (Screen.width / 2 - 60f, Screen.height / 1.5f + 10f, 110f, 50f), "HOW TO PLAY")) {
				//26. Load the main screne which is 1 in the BUILD SETTINGS
				Application.LoadLevel (3);
			}

		if (GUI.Button (new Rect (Screen.width / 2 - 60f, Screen.height / 1.2f + 10f, 110f, 50f), "EXIT GAME")) {
			//26. Load the main screne which is 1 in the BUILD SETTINGS
			Application.Quit();

		}
			//40. Set the yellow style for the high scores
			//GUI.skin = style2;
			
			//37. Add a label to show high score
			//GUI.Label (new Rect (Screen.width / 100f, Screen.height / 50f, 500f, 100f), "High score: " + PlayerPrefs.GetInt ("score"));
			
		}
		
		
		
		
		
		
		// Use this for initialization
		void Start () {
			
		}
		
		
		// Update is called once per frame
		void Update () {
			
		}
	}
