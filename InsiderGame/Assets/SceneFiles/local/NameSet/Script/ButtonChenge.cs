using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonChenge : MonoBehaviour
{

    public GameObject NameManager;
    public int ButtonNameCount;
    private NameInputField NameSetScript;

    private Text ButtonText;

    private int TrueCount = 0;//charjudge関数のカウントUPでしか使ってないやつ

    public bool fildflg;
    // Use this for initialization
    void Start()
    {
        ButtonText = this.GetComponent<Text>();
        NameSetScript = NameManager.GetComponent<NameInputField>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < NameSetScript.Provisional; i++)
        {
            for (int k = 0; k < NameSetScript.Provisional; k++)
            {
                //同名禁止の為のif文
                if (i != k)
                {
                    if (NameSetManager.PlayerName[i] == NameSetScript.inputfield[k].text)
                    {
                        fildflg = false;
                    }
                }
                else
                {
                    if (NameSetManager.PlayerName[i] == NameSetScript.inputfield[k].text)
                    {
                        fildflg = true;
                    }
                    else
                    {
                        fildflg = false;
                    }
                }
                if (!fildflg) break;
            }
            if (!fildflg) break;
        }
        charjudge();
    }

    void charjudge()
    {
        TrueCount = 0;
        for (int i = 0; i < NameSetScript.Provisional; i++)
        {
            if (NameSetManager.PlayerName[i] != NameSetScript.InputName[i] || !fildflg)
            {
                ButtonText.text = "決定";
                break;
            }
            else
            {
                TrueCount++;
            }
        }
        if (TrueCount == NameSetScript.Provisional)
        {
            ButtonText.text = "次へ";
        }
    }
}
