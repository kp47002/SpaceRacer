using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private bool isSpawning;
	public GameObject cube;
	public GameObject pannel;
	// Use this for initialization
	void Start () {
		isSpawning = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isSpawning)
        {
            float timer = Random.Range(1, 2);
            Invoke("SpawnObject", timer);
            isSpawning = true;
        }
		//float timer2 = 5;
         //   Invoke("SpawnPannel", timer2);
	}
	void SpawnObject()
    {
        // Code to spanw your Prefab here
		int lane = Random.Range(-1, 1);
		Instantiate(cube, new Vector3(-22, 0.4f, lane), Quaternion.identity);
        isSpawning = false;
    }
	void SpawnPannel()
    {
        // Code to spanw your Prefab here
		
		 Instantiate(pannel, new Vector3(-22, 0.4f, 0), Quaternion.identity);
		
        
    }
}
