using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;





    void Awake()
    {

        scoreText.text = Score.score.ToString();
        highScoreText.text = Score.highScore.ToString();


    }
    public void playGame()
    {



        Debug.Log("Change SCENE!!");
        SceneManager.LoadScene(1);


    }
}




