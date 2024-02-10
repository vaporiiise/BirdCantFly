using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorehandler : MonoBehaviour
{
    public TMP_Text ScoreUI;
    private scoremanager _scoreManager;
    void Start()
    {
        _scoreManager = FindObjectOfType<scoremanager>();
        ScoreUI = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (_scoreManager == null)
            return;

        if (ScoreUI == null)
            return;

        ScoreUI.text = _scoreManager.Score.ToString();
    }
}
