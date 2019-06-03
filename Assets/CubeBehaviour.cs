﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    Vector3 direction = new Vector3(1.0f, 0.0f, 0.0f);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * GameManager.speed * Time.deltaTime);
        if (transform.position.x > 25)
        {
            Destroy(gameObject);
            Destroy(this);
        }


    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("col");
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.tag == "enemy")
            {

                GameManager.GameOver();
            }
            if (gameObject.tag == "coin")
            {
                GameManager.score += 1000;
            }
        }
        Destroy(gameObject);
        Destroy(this);
    }

}
