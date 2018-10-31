using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class JobDisplay : MonoBehaviour
{
    public GameObject RoleDectdeOJ = null;
    public Text nametext = null;//inspectorで中身を代入//職のtext

    private const string master = "マスター";
    private const string common = "コモン";
    private const string insider = "インサイダー";

    public Sprite commonimage;
    public Sprite masterimage;
    public Sprite insiderimage;

    public Image JobImage;

    void Start()
    {
        RoleDectdeOJ = GameObject.Find("RoleDecideManager");

        switch (RoleDecideManager.RoleNumber[RoleDectdeOJ.GetComponent<NameDraw>().DrawNameNumber])
        {
            case RoleDecideManager.Role.Common:
                nametext.GetComponent<Text>().text = common;
                JobImage.GetComponent<Image>().sprite = commonimage;
                break;

            case RoleDecideManager.Role.Master:
                nametext.GetComponent<Text>().text = master;
                JobImage.GetComponent<Image>().sprite = masterimage;
                break;

            case RoleDecideManager.Role.Insider:
                nametext.GetComponent<Text>().text = insider;
                JobImage.GetComponent<Image>().sprite = insiderimage;
                break;
        }
    }

    void Update()
    {

    }

    public void AllColect()
    {
        SceneManager.LoadScene("RoleDecide");
    }
}
