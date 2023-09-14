using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerValue = 3;
    public Text timeText;

    private void Update()
    {
        timerValue -= Time.deltaTime;

        timeText.text = "" + timerValue.ToString("f0");

        if(timerValue < 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
