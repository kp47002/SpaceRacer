using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        transform.Translate(direction * 15 * Time.deltaTime);
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

                SceneManager.LoadScene(0);
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
