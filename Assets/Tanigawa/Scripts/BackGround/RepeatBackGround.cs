using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    private Vector2 startPos;
    private float repeatWidth;

    void Start()
    {
        startPos = transform.position;//‰Šú’læ“¾
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 2;
    }

    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
