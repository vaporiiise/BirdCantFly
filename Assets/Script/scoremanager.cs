using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    public int Score = 0;

    public void AddScore(int score)
    {
        Score += score;
        Debug.Log(message: "Score" + Score);
    }

    public void Start()
    {
        PlayerPrefs.SetInt("finalscore", Score);
        PlayerPrefs.Save();
    }
}
