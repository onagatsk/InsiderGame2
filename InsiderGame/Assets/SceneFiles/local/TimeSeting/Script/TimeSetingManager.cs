using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TimeSetingManager : MonoBehaviour
{
    private const int MaxTime = 15;
    private const int MinTime = 1;

    public InputField inputField;

    private string S_SetTime;
    public int SetTime;

    void Start()
    {
        //string型の初期化
        S_SetTime = "3";
        SetTime = 3;
    }

    void Update()
    {
        if (0 > inputField.text.IndexOf("-"))
        {
            //inputfildの中身が空の場合
            if (inputField.text != "")
            {
                //中身が規定値以上
                if (Convert.ToInt32(inputField.text) >= MaxTime)
                {
                    inputField.text = Convert.ToString(MaxTime);
                    SetTime = MaxTime;
                }
                //中身が規定値以下
                else if (Convert.ToInt32(inputField.text) <= MinTime)
                {
                    inputField.text = Convert.ToString(MinTime);
                    SetTime = MinTime;
                }
                //中身が規定値内
                else
                {
                    SetTime = Convert.ToInt32(inputField.text);
                }

            }
        }
        else
        {
            inputField.text = "";
        }
    }
    public void RightButtonDown()
    {
        SetTime++;
        if (SetTime <= MaxTime)
        {
            S_SetTime = Convert.ToString(SetTime);
            inputField.text = S_SetTime;
        }
        else
        {
            SetTime--;
        }

    }
    public void LeftButtonDown()
    {
        SetTime--;
        if (SetTime >= MinTime)
        {
            S_SetTime = Convert.ToString(SetTime);
            inputField.text = S_SetTime;
        }
        else
        {
            SetTime++;
        }
    }
}
