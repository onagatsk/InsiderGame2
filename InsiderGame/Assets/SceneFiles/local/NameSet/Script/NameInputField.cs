using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class NameInputField : NameSetManager
{
    public InputField[] inputfield = new InputField[10];
    public string[] InputName; //入力された名前
    public int InputCount;
    public Text ButtonText;

    void Start()
    {
        //参加人数、人数分の配列の確保
        BaseStart();
        InputName = new string[Provisional];
        InputCount = Provisional;

        for (int i = 10; i > Provisional; i--)
        {
            //Destroy(inputfield[i]);
            inputfield[i - 1].gameObject.SetActive(false);
        }
        //string型の初期化
        for (int i = 0; i < Provisional; i++)
        {
            InputName[i] = "";
        }
        //InputFieldの初期化
        InitInputField();
    }

    void Update()
    {

    }

    public void InitInputField()
    {
        for (int i = 0; i < Provisional; i++)
        {
            //テキスト初期化
            inputfield[i].text = "";

            //フォーカス
            inputfield[i].ActivateInputField();
        }
    }

    public void NameSet()
    {
        if (InputCount != 0)
        {
            for (int i = 0; i < Provisional; i++)
            {
                InputName[i] = inputfield[i].text;
                if (InputName[i] != "")
                {
                    PlayerName[i] = InputName[i];
                    InputCount--;
                }
                else
                {
                    InputCount = Provisional;
                }
            }
        }
        else
        {
            int SceneChengeCounter = 0;
            for (int i = 0; i < Provisional; i++)
            {
                if (PlayerName[i] != inputfield[i].text)
                {
                    InputName[i] = inputfield[i].text;

                    if (InputName[i] != "")
                    {
                        PlayerName[i] = InputName[i];
                    }
                    else
                    {
                        InputCount = Provisional;
                    }
                }
                else
                {
                    SceneChengeCounter++;
                }
            }
            if (SceneChengeCounter == Provisional && ButtonText.text == "次へ")
            {
                SceneManager.LoadScene("RoleDecide");
            }
        }
    }
}
