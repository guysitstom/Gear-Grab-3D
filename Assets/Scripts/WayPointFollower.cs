using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    public Transform[] points;
    int current;
    public float speed;

    void Start()
    {
        current = 0;
        Invoke("SpeedChange", 5);
    }

    void SpeedChange()
    {
        speed = 30f;
    }

    void Update()
    {
        if (transform.position != points[current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, Time.deltaTime * speed);

        }
        else
            current =(current+1)%points.Length;
    }
}