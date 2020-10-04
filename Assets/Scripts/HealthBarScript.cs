using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour
{

    public Sprite threeFourths;
    public Sprite half;
    public Sprite oneFourth;
    public Sprite zero;

    public SpriteRenderer sr;

    public GameControllerScript gc;
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
        sr = GetComponent<SpriteRenderer>();
    }

    public void UpdateHealthBar()
    {
        if(gc.pickedAmount == 1)
        {
            sr.sprite = threeFourths;
        }
        if (gc.pickedAmount == 2)
        {
            sr.sprite = half;
        }
        if (gc.pickedAmount == 3)
        {
            sr.sprite = oneFourth;
        }
        if (gc.pickedAmount == 4)
        {
            sr.sprite = zero;
        }
    }
}
