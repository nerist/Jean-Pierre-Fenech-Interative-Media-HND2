using UnityEngine;
using System.Collections;

public class StarScript : MonoBehaviour {

		void Awake()
		{
			//rigidbody.AddForce(new Vector3(0, -100, 0), ForceMode.Force);
		}
		
		void Update () {
			float fallSpeed = 5 * Time.deltaTime;
			transform.position -= new Vector3(0, fallSpeed, 0);
			
			transform.Rotate (Vector3.forward * 400f * Time.deltaTime);
			
			if (transform.position.y < -.60 || transform.position.y >= 20)
			{
				//Destroy this gameobject (and all attached components)
				Destroy(gameObject);
			}
		}
	}
