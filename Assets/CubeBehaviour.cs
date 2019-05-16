using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {

	Vector3 direction = new Vector3(1.0f, 0.0f, 0.0f);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 transform.Translate(direction *15* Time.deltaTime);
		 if (transform.position.x>25)
		 {
			 Destroy(gameObject);
			 Destroy(this);
		 }
		
	}
}
