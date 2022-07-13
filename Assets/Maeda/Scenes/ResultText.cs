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
            text.text = "1Pの勝ち！\nおめでとう！";
            text.color = Color.blue;
        }
        else if (win == 2)
        {
            text.text = "2Pの勝ち！\nおめでとう！";
            text.color= Color.red;
        }
        else
        {
            text.text = "引き分け";
            text.color = Color.green;
        }
    }
}
