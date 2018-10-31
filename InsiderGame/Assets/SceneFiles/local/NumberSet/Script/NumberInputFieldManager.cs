using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class NumberInputFieldManager : MonoBehaviour {

    public InputField inputField;

    private string SGameMember;

    public static int IGameMenber = 5; //人数
    
    void Start () {
        //string型の初期化
        SGameMember = "";
        //InputFieldの初期化
        InitInputField();
    }
	
	void Update ()
    {
	}

    public void InitInputField()
    {
        //テキスト初期化
        inputField.text = "";

        //フォーカス
        inputField.ActivateInputField();
    }

    public void SecneChange()
    {
        SGameMember = inputField.text;

        if (SGameMember != "")
        {
            Int32.TryParse(SGameMember, out IGameMenber);
            if(IGameMenber >= 3 && IGameMenber <= 10)
            {
                InitInputField();
                SceneManager.LoadScene("NameSet");
            }
            else
            {
                InitInputField();
            }
        }
    }
}
