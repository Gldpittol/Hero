using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverButtonScript : MonoBehaviour
{

    public Text loopText;
   

    void Update()
    {
        loopText.text = "Current Loop: " + (StaticVariables.currentDialog + 1);
    }
}
