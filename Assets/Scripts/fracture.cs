﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fracture : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("i");
        Explode();
    }

    // Update is called once per frame
    public void Explode()
    {
        Debug.Log("explode");
        int i = 0;
        foreach (Transform t in this.transform)
        {
            i++;

            var rb = t.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Debug.Log(i);
                rb.AddExplosionForce(Random.Range(100, 300), transform.position, 5);
            }
        }
    }
}