using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorehandler : MonoBehaviour
{
    public TMP_Text ScoreUI;
    private scoremanager _scoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = FindObjectOfType<scoremanager>();
        ScoreUI = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_scoreManager == null)
            return;

        if (ScoreUI == null)
            return;

        ScoreUI.text = _scoreManager.Score.ToString();
    }
}
