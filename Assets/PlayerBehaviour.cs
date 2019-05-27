using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehaviour : MonoBehaviour
{

    int lane;
    bool left = false, right = false;
    // Use this for initialization
    void Start()
    {
        lane = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("right") & right == false)
        {
            right = true;
            if (lane < 2)
            {
                lane++;
            }
        }
        else if (!Input.GetKey("right"))
        {
            right = false;
        }
        if (Input.GetKey("left") & !left)
        {
            left = true;
            if (lane > -2)
            {
                lane--;
            }
        }
        else if (!Input.GetKey("left"))
        {
            left = false;
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, lane);

    }

}
