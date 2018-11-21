using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ThemeSettingManager : MonoBehaviour
{
    private const int MaxFontSize = 50;
    public InputField inputField;
    public static string Theme = "";

    void Start()
    {

    }

    void Update()
    {
        if (inputField.text != "")
        {
            Theme = inputField.text;
            GameObject InputFieldText;
            InputFieldText = inputField.transform.Find("Text").gameObject;

            if (inputField.GetComponent<RectTransform>().sizeDelta.x - InputFieldText.GetComponent<Text>().fontSize / 2.0f < inputField.preferredWidth)
            {
                for (float i = inputField.GetComponent<RectTransform>().sizeDelta.x - InputFieldText.GetComponent<Text>().fontSize / 2.0f; i < inputField.preferredWidth; )
                {
                    InputFieldText.GetComponent<Text>().fontSize -= 1;
                }
            }

            else if (inputField.GetComponent<RectTransform>().sizeDelta.x > inputField.preferredWidth)
            {
                for (float i = inputField.GetComponent<RectTransform>().sizeDelta.x - InputFieldText.GetComponent<Text>().fontSize / 2.0f;
                    InputFieldText.GetComponent<Text>().fontSize <= MaxFontSize && i - inputField.preferredWidth > 50; )
                {
                    InputFieldText.GetComponent<Text>().fontSize += 1;
                }
            }
        }

    }

    public void DecisionButtonDown()
    {
        if (inputField.text != "" && inputField.text != null)
        {
            SceneManager.LoadScene("insiderConfirmation");
        }
    }
}
