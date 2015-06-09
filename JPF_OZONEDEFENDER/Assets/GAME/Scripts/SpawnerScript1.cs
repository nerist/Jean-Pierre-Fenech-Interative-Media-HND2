using UnityEngine;
using System.Collections;

public class SpawnerScript1 : MonoBehaviour {

    public Transform BarrelPrefab;

    private float nextBarrelTime = 0.0f;
    private float spawnRate = 2f;
 	
	void Update () {
        if (nextBarrelTime < Time.time)
        {
            SpawnBarrel();
            nextBarrelTime = Time.time + spawnRate;

            //Speed up the spawnrate for the next egg
            spawnRate *= 0.98f;
            spawnRate = Mathf.Clamp(spawnRate, 3f, 50f);
        }
	}

    void SpawnBarrel()
    {
        float addXPos = Random.Range(-4f, 4f);
        Vector3 spawnPos = transform.position + new Vector3(addXPos,2f,0.75f);
        Instantiate(BarrelPrefab, spawnPos, Quaternion.identity);
    }
}
