using UnityEngine;
using System.Collections;

public class pauseScript : MonoBehaviour {


	// Use this for initialization

		void Start ()
		{
			Screen.showCursor = false;
		}
	

	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;

				GameObject varGameObject = GameObject.FindWithTag ("Player");
				
				varGameObject.GetComponent<PlayerScript> ().enabled = false;

				GameObject varGameObject2 = GameObject.FindWithTag ("pause");

				varGameObject2.GetComponent<Renderer>().enabled = true;
				
				//varGameObject2.gameObject.active = true;
			}
			else
			{
				Time.timeScale = 1;

				GameObject varGameObject = GameObject.FindWithTag ("Player");
				
				varGameObject.GetComponent<PlayerScript> ().enabled = true;

				GameObject varGameObject2 = GameObject.FindWithTag ("pause");
				
				//varGameObject2.gameObject.active = false;

				varGameObject2.GetComponent<Renderer>().enabled = false;
			}
		}

	}


}
