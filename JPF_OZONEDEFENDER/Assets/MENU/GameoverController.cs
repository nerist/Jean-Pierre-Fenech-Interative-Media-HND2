using UnityEngine;
using System.Collections;

public class GameoverController : MonoBehaviour {

		public GUISkin style;
		public GUISkin style2;
		
		//18. added GUI to menu controller
		void OnGUI()
		{
			//21.Add the skin to the GUI
			GUI.skin = style;
			
			
			//25. Load the main game
			if (GUI.Button (new Rect (Screen.width / 2 - 60f, Screen.height / 1.5f + 100f, 125f, 50f), "BACK TO MAIN MENU")) {
				//26. Load the main screne which is 1 in the BUILD SETTINGS
				Application.LoadLevel (0);
			}
			

			//40. Set the yellow style for the high scores
			GUI.skin = style2;
			
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
