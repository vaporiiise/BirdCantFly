using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float MoveSpeed = 100f;
    void FixedUpdate()
    {
        Vector2 targetMovePos = transform.position;
        targetMovePos.x -= MoveSpeed * Time.deltaTime;
        transform.position = targetMovePos;
    }
    
}

    
