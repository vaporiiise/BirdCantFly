using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (!collision.gameObject.CompareTag("Player"))
            return;
        
        Debug.Log(message: "we have crashed!");
        GameObject.Destroy(collision.gameObject);
    }
    
}
