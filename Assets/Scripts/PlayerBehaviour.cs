using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBehaviour : MonoBehaviour
{
    public GameObject shadow;
    public GameObject PlayerFracture;

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
                Instantiate(shadow, new Vector3(22, 0.5f, lane), Quaternion.Euler(0, -90, 0));

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
                Instantiate(shadow, transform.position, Quaternion.Euler(0, -90, 0));

                lane--;
            }
        }
        else if (!Input.GetKey("left"))
        {
            left = false;
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, lane);

    }
    public void Destroy()
    {

        Transform child = transform.Find("Main Camera"); //Replace "ChildName" with the child objects name.
        child.parent = null;

        Instantiate(PlayerFracture, PlayerFracture.transform.position + new Vector3(0, 0, lane), Quaternion.Euler(0, -90, 0));
        Destroy(gameObject);
        Destroy(this);
    }

}
