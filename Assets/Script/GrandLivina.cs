using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandLivina : MonoBehaviour
{
    public float upwardforce = 500;
    private Rigidbody2D _rigidbody;
    private Collider2D _collider;
    public int integer = 2;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidbody == null)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector2.up * upwardforce);
            _rigidbody.velocity = Vector2.zero;
            Debug.Log(message: "we should flap upwards!");
        }
    }
}
