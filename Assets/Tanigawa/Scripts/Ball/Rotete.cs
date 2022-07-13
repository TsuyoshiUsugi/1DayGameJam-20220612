using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotete : MonoBehaviour
{
    public float speed = 5;
    private float pos;
    bool p1;
    bool p2;
    private void Start()
    {
        pos = transform.position.x;
        if (pos < 0)
        {
            p1 = true;
        }
        else if (pos > 0)
        {
            p2 = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (p1)
        {
            transform.Rotate(0, 0, -speed);
        }

        else if (p2) 
        {
            transform.Rotate(0, 0, speed);
        }
    }
}
