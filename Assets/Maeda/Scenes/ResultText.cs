using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResultText : MonoBehaviour
{
    public static int win = 0;
    public Text text;
    void Start()
    {

    }
    void Update()
    {
        if (win == 1)
        {
            text.text = "1P�̏����I\n���߂łƂ��I";
            text.color = Color.blue;
        }
        else if (win == 2)
        {
            text.text = "2P�̏����I\n���߂łƂ��I";
            text.color= Color.red;
        }
        else
        {
            text.text = "��������";
            text.color = Color.green;
        }
    }
}
