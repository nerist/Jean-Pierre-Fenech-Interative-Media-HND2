using UnityEngine;
using System.Collections;

public class BarrelCollider : MonoBehaviour {
	public AudioClip barrelhit;

	PlayerScript myPlayerScript;



    void Awake()
    {
        myPlayerScript = transform.parent.GetComponent<PlayerScript>();
    }




	void OnTriggerEnter(Collider collision) {
		if(collision.gameObject.tag == "barrel")	
		{
			DestroyObject(collision.gameObject);
			audio.Play();


			myPlayerScript.lives--;

		}
	}
}

