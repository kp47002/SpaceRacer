using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CubeBehaviour : MonoBehaviour
{




    Vector3 direction = new Vector3(1.0f, 0.0f, 0.0f);
    bool collected = false;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * GameManager.speed * Time.deltaTime, Space.World);
        if (gameObject.tag == "coin")
            transform.Rotate(10, 0, 0, Space.Self);
        if (transform.position.x > 25)
        {
            Destroy(gameObject);
            Destroy(this);
        }


    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (gameObject.tag == "enemy")
            {

                if (other.gameObject.name == "RealPlayer")
                {
                    try
                    {

                        other.gameObject.GetComponent<PlayerBehaviour>().Destroy();
                    }
                    catch (System.Exception)
                    {


                    }
                }


                GameManager.GameOver();
            }
            if (gameObject.tag == "coin")
            {
                if (!collected)
                {
                    collected = true;

                    GameManager.score += 1000;
                    GameManager.dynamiclySetScore(1000);
                }
                Destroy(gameObject);

                Destroy(this);
            }
        }
    }

}
