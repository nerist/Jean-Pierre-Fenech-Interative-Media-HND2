using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public int lives = 3;
	public int theScore = 0;
	public int spin = 0;
	public GUISkin style;
	public GUISkin style2;
	
	//void Awake() {
	//	DontDestroyOnLoad(transform.gameObject);
	//}
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		{
			//translate to viewport coordintaes
			Vector3 viewportCoordinates = Camera.main.ScreenToViewportPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
			
			//translated to the correct coordinates
			Vector3 worldCoordinates = Camera.main.ViewportToWorldPoint (viewportCoordinates);
			
			transform.position = new Vector3 (Mathf.Clamp (-worldCoordinates.x, -4f, 4f), -1f, -6f);
		}
		
		{
			// skip to next lvl if score is 5
			if (theScore == 25) {
				Application.LoadLevel (4);
			} }
		
		{
			if (theScore == 50) {
				Application.LoadLevel (5);
			} }
		
		{
			if (theScore == 200) {
				Application.LoadLevel (6);
			} }
		
		{
			if (lives == 0) {
				Application.LoadLevel (2);
			} }
		
	}
	
	
	
	
	void OnGUI()
		
	{
		
		GUI.skin = style;
		//We display the game GUI from the playerscript
		//It would be nicer to have a seperate script dedicated to the GUI though...
		GUILayout.Label("Score: " + theScore);
		
		
		
		
		GUI.skin = style;
		//We display the game GUI from the playerscript
		//It would be nicer to have a seperate script dedicated to the GUI though...
		GUILayout.Label("Lives:" + lives);
	}  
	
}



