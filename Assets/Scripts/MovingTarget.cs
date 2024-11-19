using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public float amplitude = 2f; 
    public float frequency = 1f; 
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
       
        transform.position = startPosition + new Vector3(0, Mathf.Sin(Time.time * frequency) * amplitude, 0);
    }
}
