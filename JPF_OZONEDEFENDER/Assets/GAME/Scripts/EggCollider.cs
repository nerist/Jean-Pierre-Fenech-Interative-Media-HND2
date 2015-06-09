using UnityEngine;
using System.Collections;

public class EggCollider : MonoBehaviour {

	public AudioClip eggfall;

    PlayerScript myPlayerScript;

    void Awake()
    {
        myPlayerScript = transform.parent.GetComponent<PlayerScript>();
    }


      
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "egg") {
			DestroyObject (other.gameObject);
			audio.Play ();

			myPlayerScript.theScore++;
		}
		
	}

		}

