using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalVelocityRotator : MonoBehaviour
{
    public float RotateUp = 60f;
    public float RotateDown = -20f;
    private GrandLivina _grandLivina;

    private float _currenty;

    private float _lasty;

    private float Velocity = 0f;
    // Start is called before the first frame update
    void Start()
    {
        _grandLivina = transform.parent.GetComponent<GrandLivina>();
        _currenty = _lasty = transform.parent.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_grandLivina == null)
            return;

        _currenty = _grandLivina.transform.position.y;

        Velocity = _currenty - _lasty;

        Velocity *= 10f;
        Velocity = Mathf.Clamp(Velocity, -1, 1);
        Velocity = Unity.Mathematics.math.remap(-1, 1, 0, 1, Velocity);
        transform.rotation = Quaternion.Lerp(Quaternion.Euler(0,0, RotateDown),Quaternion.Euler(0,0, RotateUp), Velocity);
        _lasty = _grandLivina.transform.position.y;
    }
}
