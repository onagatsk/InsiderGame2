using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class insiderConfirmation2Manager : MonoBehaviour
{

    public Text themetext;

	void Start () {
        themetext.text = ThemeSettingManager.Theme;
	}
	
	void Update () {
        if (themetext.GetComponent<RectTransform>().sizeDelta.x - themetext.GetComponent<Text>().fontSize / 2.0f < themetext.preferredWidth)
        {
            for (float i = themetext.GetComponent<RectTransform>().sizeDelta.x - themetext.GetComponent<Text>().fontSize / 2.0f; i < themetext.preferredWidth; )
            {
                themetext.GetComponent<Text>().fontSize -= 1;
            }
        }
	}

    public void SceneChenge()
    {
        SceneManager.LoadScene("GameStart");
    }
}
