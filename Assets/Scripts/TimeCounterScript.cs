using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounterScript : MonoBehaviour
{

    public Text timeText;
    public float time;

    void Start()
    {
        time = 0;
    }

    void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString("F2").Replace(",", ".") + "s"; 
    }
}
