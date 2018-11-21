using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class insiderConfirmationManager : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("insiderConfirmation2");
    }

}
