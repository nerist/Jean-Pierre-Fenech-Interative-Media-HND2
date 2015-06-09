using UnityEngine;
using System.Collections;

public class BarrelScript : MonoBehaviour {
	

    void Awake()
    {
        //rigidbody.AddForce(new Vector3(0, -100, 0), ForceMode.Force);
    }

	void Update () {
        float fallSpeed = 20 * Time.deltaTime;
        transform.position -= new Vector3(0, fallSpeed, 0);

		transform.Rotate (Vector3.right * 300f * Time.deltaTime);

        if (transform.position.y < -1.1 || transform.position.y >= 24)
        {
            //Destroy this gameobject (and all attached components)
            Destroy(gameObject);
        }
	}
}
