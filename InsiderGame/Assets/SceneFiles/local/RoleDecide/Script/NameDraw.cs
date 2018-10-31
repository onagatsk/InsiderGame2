using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameDraw : MonoBehaviour
{
    private Text nametext;//inspectorで中身を代入
    private Text Leary;//ほんまか？のオブジェクト
    private Button buttonseting;//button入れるとこ
    public int DrawNameNumber = 0;//こいつを加算したら名前が変わる
    
    void Start()
    {
        GameObject Instansnametextobject = GameObject.Find("名前");
        GameObject Instanslearytextobject = GameObject.Find("ほんまか？");
        nametext = Instansnametextobject.GetComponent<Text>();
        Leary = Instanslearytextobject.GetComponent<Text>();
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
        Leary.gameObject.SetActive(false);
        //人数設定→名前設定からの遷移でないとstatic変数が空なのでエラーを吐く
        nametext.text = NameSetManager.PlayerName[DrawNameNumber];
    }

    void Intialize()
    {
        GameObject Instansnametextobject = GameObject.Find("名前");
        GameObject Instanslearytextobject = GameObject.Find("ほんまか？");
        GameObject Instansbuttonsetingobject = GameObject.Find("Button");
        nametext = Instansnametextobject.GetComponent<Text>();
        Leary = Instanslearytextobject.GetComponent<Text>();
        buttonseting = Instansbuttonsetingobject.GetComponent<Button>();
        buttonseting.onClick.AddListener(YesButtonDown);
        Leary.gameObject.SetActive(false);
        nametext.text = NameSetManager.PlayerName[DrawNameNumber];
    }

    void Update()
    {

    }

    public void YesButtonDown()
    {
        if (!Leary.gameObject.activeSelf)
        {
            Leary.gameObject.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("JobDisplay");
        }
    }
    void OnActiveSceneChanged(Scene i_preChangedScene, Scene i_postChangedScene)
    {
        if (SceneManager.GetActiveScene().name == "RoleDecide")
        {
            if (DrawNameNumber < NumberInputFieldManager.IGameMenber - 1)
            {
                DrawNameNumber++;
                Intialize();
            }
            else
            {
                SceneManager.LoadScene("TimeSetting");
            }
        }
    }

    void firstDown()
    {

    }
    void SecondDown()
    {
    }
}
