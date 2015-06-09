using UnityEngine;
using System.Collections;

public class PowerScript : MonoBehaviour {

		
		public Transform StarPrefab;
		
		private float nextStarTime = 0.0f;
		//controlls the spawn rate of the powerup
		private float spawnRate = 5f;
		
		void Update () {
			if (nextStarTime < Time.time)
			{
				SpawnStar();
				nextStarTime = Time.time + spawnRate;
				
				//Speed up the spawnrate for the next egg
				spawnRate *= 0.98f;
				spawnRate = Mathf.Clamp(spawnRate, 0.3f, 99f);
			}
		}
		
		void SpawnStar()
		{
			float addXPos = Random.Range(-4f, 4f);
			Vector3 spawnPos = transform.position + new Vector3(addXPos,2f,0.75f);
			Instantiate(StarPrefab, spawnPos, Quaternion.identity);
		}
	}