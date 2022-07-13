using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMoveLeft : MonoBehaviour
{
    public float speed = 1;
    private float posX;

    void Start() 
    {
        posX = transform.position.x;
    }
    // Update is called once per frame
    void Update()
    {
        posX += speed;
    }
}
