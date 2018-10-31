using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelectMulti()
    {
        Debug.Log("今はまだないよ！");
    }

    public void SelectLocal()
    {
        SceneManager.LoadScene("NumberSet");
    }
}
