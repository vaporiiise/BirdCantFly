using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    public int ScoreAmount = 1;
    private scoremanager _scoremanager;
    void Start()
    {
        _scoremanager = FindAnyObjectByType<scoremanager>();
    }

    // Update is called once per frame
    void UpdateOnTriggerEnter2D(Collider2D collider)
    {
        if (_scoremanager == null) { return; }


        _scoremanager.AddScore(ScoreAmount);
        //Debug.Log(message: "Add score " + ScoreAmount);
    }
        
    
}
