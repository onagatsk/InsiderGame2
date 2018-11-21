using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameMainManager : MonoBehaviour
{

    //public Text Minute;     //秒
    //public Text Time;       //分
    public GameObject M1;
    public GameObject M10;
    public GameObject S1;
    public GameObject S10;
    public GameObject EndPanele;

    public Sprite[] S_image;

    private float TotalTaime;
    private const int MinuteSeconds = 60;

    private bool scenechangeflg = false;
    void Start()
    {
        //TotalTaime = TimeSetingManager.SetTime * MinuteSeconds;
        TotalTaime = 1 * MinuteSeconds + 1;
    }

    void Update()
    {
        if (TotalTaime >= 0.0f && !scenechangeflg)
        {
            TotalTaime -= UnityEngine.Time.deltaTime;
            MinuteSet(TotalTaime);
            SecondSet(TotalTaime);
        }
        else
        {
            SceneChange();
        }

        if (scenechangeflg)
        {
            SceneChange();
        }
    }

    void SecondSet(float time)
    {
        int second = (int)time % MinuteSeconds;
        NumberSet(S10, second / 10);
        NumberSet(S1, second % 10);

    }
    void MinuteSet(float time)
    {
        int minute = (int)time / MinuteSeconds;
        NumberSet(M10, minute / 10);
        NumberSet(M1, minute % 10);

    }

    void NumberSet(GameObject TargetImage, int time)
    {
        TargetImage.GetComponent<Image>().sprite = S_image[time];
    }

    public void SceneChange()
    {
        Vector3 InitPosition;
        InitPosition = EndPanele.GetComponent<RectTransform>().position;
        EndPanele.GetComponent<Image>().color += new Color(0.0f, 0.0f, 0.0f, 0.01f);
        if (EndPanele.GetComponent<RectTransform>().localPosition.y <= 0.0f && EndPanele.GetComponent<Image>().color.a >= 1.0f)
        {
            //SceneManager.LoadScene("GameStart");
        }
        else
        {
            EndPanele.GetComponent<RectTransform>().position -= new Vector3(0.0f, 1.0f, 0.0f);
        }
    }
    public void ButtonSceneChange()
    {
        scenechangeflg = true;
    }
    public void GameStop()
    {

    }

}
