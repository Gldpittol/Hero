using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverButtonScript : MonoBehaviour
{

    public Text loopText;
   

    void Update()
    {
        loopText.text = "Current Loop: " + (StaticVariables.currentDialog);
        if(Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("The Room", LoadSceneMode.Single);
        }

    }
}
