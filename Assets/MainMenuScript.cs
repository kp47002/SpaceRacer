using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public void playGame()
    {

        SceneManager.LoadScene(1);
        Debug.Log("Change SCENE!!");

    }
}




