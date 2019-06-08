using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Text dynamicScoreText;

    public static int dynamicScore = 0;

    private bool isSpawning;
    public GameObject cube;
    public GameObject coin;
    public GameObject pannel;
    public static int score = 0;

    // public Text dynamicScoreText;

    // public static int dynamicScore = 0;
    public static int highScore = 0;
    double difficulty = 1;
    public Text scoreText;
    static float GameOverTimer = 2;
    public static int speed = 13;
    public static bool play = false;



    int rotation = 0;
    int difficultyFactor;
    // Use this for initialization
    void Start()
    {
        isSpawning = false;
        play = true;
        score = 0;
        //dynamicScore = 0;
        GameOverTimer = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {


            difficulty = 1 + score / 20000;
            difficultyFactor = (int)System.Math.Ceiling(difficulty * 2);
            score += difficultyFactor;
            speed = 13 + 2 * difficultyFactor;
            if (!isSpawning)
            {
                float timer = Random.Range(1, 2);
                Invoke("SpawnObject", timer);
                isSpawning = true;
            }
            scoreText.text = "SCORE: " + score.ToString();
            dynamicScoreText.text = "+" + score.ToString();

            //dynamicScoreText.text = "+" + dynamicScore.ToString();
            //float timer2 = 5;
            //   Invoke("SpawnPannel", timer2);
        }
        else
        {
            GameOverTimer -= Time.deltaTime;
            if (GameOverTimer < 0)
            {

                SceneManager.LoadScene(1);
            }
        }
    }
    void SpawnObject()
    {
        int coinValue = 0;
        int enemyValue = 0;
        rotation++;

        int randomSeed = Random.Range(0, 100);
        for (int i = 0; i < 5; i++)
        {
            int randomValue = Random.Range(0, 100);

            if (randomValue * difficulty > (25 + enemyValue) && enemyValue < 100)
            {
                enemyValue += 25;
                Instantiate(cube, new Vector3(-22, 0.5f, (i + randomSeed) % 5 - 2), Quaternion.Euler(0, -90, 90));
            }
            else if (randomValue * difficulty > (25) && coinValue == 0)
            {
                coinValue++;
                Instantiate(coin, new Vector3(-22, 0.5f, (i + randomSeed) % 5 - 2), Quaternion.Euler(0, 90, 90));
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
    public static void GameOver()
    {


        if (score > highScore)
        {
            highScore = score;
        }
        play = false;

        Score.score = score;
        Score.highScore = highScore;

    }
}
