using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class RoleDecideManager : MonoBehaviour
{
    private static RoleDecideManager Singleton = null;

    static RoleDecideManager instance
    {
        get { return Singleton ?? (Singleton = FindObjectOfType<RoleDecideManager>()); }
    }

    public enum Role
    {
        Common,
        Master,
        Insider
    }

    [SerializeField]
    public static Role[] RoleNumber;

    void Start()
    {
        if (this != instance)
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);


        RoleNumber = new Role[NumberInputFieldManager.IGameMenber];
        //マスターを決定
        setJpb(Role.Master, Role.Insider);
        //インサイダーを決定
        setJpb(Role.Insider, Role.Master);
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name != "RoleDecide" && SceneManager.GetActiveScene().name != "JobDisplay")
        {
            Destroy(this.gameObject);
        }
    }

    //第一引数がセットしたいジョブ、第二引数が避けたいジョブ
    void setJpb(Role SetJob, Role AvoidJob)
    {
        for (int Maseter = UnityEngine.Random.Range(0, NumberInputFieldManager.IGameMenber);
            RoleNumber[Maseter] != SetJob; )
        {
            if (RoleNumber[Maseter] != AvoidJob)
            {
                RoleNumber[Maseter] = SetJob;
            }
            else
            {
                Maseter = UnityEngine.Random.Range(0, NumberInputFieldManager.IGameMenber);
            }
        }
    }
}
