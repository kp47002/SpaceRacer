using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    private bool isSpawning;
    public GameObject cube;
    public GameObject coin;
    public GameObject pannel;
    public static int score = 0;
    double difficulty = 1;

    int rotation = 0;
    // Use this for initialization
    void Start()
    {
        isSpawning = false;
    }

    // Update is called once per frame
    void Update()
    {
        difficulty = 1 + score / 100000;
        score = (int)System.Math.Ceiling(difficulty * 2);
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
        int coinValue = 0;
        int enemyValue = 0;
        rotation++;

        for (int i = -2; i < 3; i++)
        {
            int randomValue = Random.Range(0, 100);

            if (randomValue * difficulty > (25 + enemyValue) && enemyValue < 100)
            {
                enemyValue += 25;
                Instantiate(cube, new Vector3(-22, 0.4f, i), Quaternion.identity);
            }
            else if (randomValue * difficulty > (25) && coinValue == 0)
            {
                coinValue++;
                Instantiate(coin, new Vector3(-22, 0.4f, i), Quaternion.identity);
            }
        }


        // Code to spanw your Prefab here

        isSpawning = false;
    }
    void SpawnPannel()
    {
        // Code to spanw your Prefab here

        Instantiate(pannel, new Vector3(-22, 0.4f, 0), Quaternion.identity);


    }
}
