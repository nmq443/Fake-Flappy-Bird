using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour
{
    public GameObject creditsPanel;
    private void Start()
    {
        creditsPanel.SetActive(false); 
    }
    public void PlayGame()
    {
        //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Credits()
    {
        creditsPanel.SetActive(true);
    }
    public void Return()
    {
        creditsPanel.SetActive(false);  
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
}
