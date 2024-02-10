using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadToSampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void LoadToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadtoCreditScene()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void LoadtoGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}

