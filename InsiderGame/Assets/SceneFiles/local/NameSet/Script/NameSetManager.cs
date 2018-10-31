using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class NameSetManager : MonoBehaviour
{
    public int Provisional;
    static public string[] PlayerName;
    
	public void BaseStart() {
        if (NumberInputFieldManager.IGameMenber == 0)
        {   
            Provisional = 5;
            PlayerName = new string[Provisional];
        }
        else
        {
            Provisional = NumberInputFieldManager.IGameMenber;
            PlayerName = new string[NumberInputFieldManager.IGameMenber];
        }
    }
	
	void Update () {
		
	}
}
