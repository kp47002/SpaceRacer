using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowScript : MonoBehaviour
{


    public float timeToLive = 1;
    Vector3 direction = new Vector3(-1.0f, 0.0f, 0.0f);


    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, timeToLive);
        transform.Translate(direction * 1 * Time.deltaTime, Space.World);
        timeToLive -= Time.deltaTime;
        if (timeToLive < 0)
        {
            Destroy(gameObject);
            Destroy(this);

        }
    }
}
