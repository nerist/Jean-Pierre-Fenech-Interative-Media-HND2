using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {

    public Transform eggPrefab;

    private float nextEggTime = 0.0f;
    private float spawnRate = 1f;
 	
	void Update () {
        if (nextEggTime < Time.time)
        {
            SpawnEgg();
            nextEggTime = Time.time + spawnRate;

            //Speed up the spawnrate for the next egg
            spawnRate *= 0.98f;
            spawnRate = Mathf.Clamp(spawnRate, 0.3f, 5f);
        }
	}

    void SpawnEgg()
    {
        float addXPos = Random.Range(-4f, 4f);
        Vector3 spawnPos = transform.position + new Vector3(addXPos,2f,0.75f);
        Instantiate(eggPrefab, spawnPos, Quaternion.identity);
    }
}
