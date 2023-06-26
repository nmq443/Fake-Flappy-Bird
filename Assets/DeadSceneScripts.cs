using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class DeadSceneScripts : MonoBehaviour
{
    public Text ScoreText;
    public Text HighestScoreText;
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        PlayerController.Points = 0;
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void Update()
    {
        ScoreText.text = "Your score: " + PlayerController.Points.ToString();
        HighestScoreText.text = "Highest score: " + PlayerController.HighestPoints.ToString();
    }
}
