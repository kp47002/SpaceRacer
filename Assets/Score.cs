using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{

    public static int score = 0;
    public static int highScore = 0;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(1);

        // Use this for initialization

    }
}