using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartManager : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}
    public void SceneChange()
    {
        SceneManager.LoadScene("GameMain");
    }
}
