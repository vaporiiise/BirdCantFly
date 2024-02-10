using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class DisplayScore : MonoBehaviour
{
    public TMP_Text scoreText;

    void Start()
    {
        int score = PlayerPrefs.GetInt("finalscore",0);
        Debug.Log(message:"scored has been retrieved");
        scoreText.text = "Score: " + score;
    }
}