using UnityEngine;
using System.Collections;

public class StarpowerCollider : MonoBehaviour {

	int randomization;
	Collider other;

		public AudioClip starsound;
		
		PlayerScript myPlayerScript;
		
		void Awake()
		{
			myPlayerScript = transform.parent.GetComponent<PlayerScript>();
		}
		
		
		IEnumerator choosespawn(){
		yield return new WaitForSeconds (0);
		randomization = Random.Range (1,4);


		if (randomization == 1) {
			myPlayerScript.lives++;
			Debug.Log ("1");
		}

		if (randomization == 2) {
			Time.timeScale = 0.3f;
			Debug.Log ("2");
			yield return new WaitForSeconds (2.5f);
			Time.timeScale = 1;

		}

		if (randomization == 3) {
			Time.timeScale = 2f;
			Debug.Log ("3");
			yield return new WaitForSeconds (10f);
			Time.timeScale = 1;


		}
	}

		void OnTriggerEnter(Collider other) {

			if (other.gameObject.tag == "star") 
		StartCoroutine ("choosespawn"); 
				DestroyObject (other.gameObject);
				audio.Play ();
				
				
			}
			
		}
		
	

	
