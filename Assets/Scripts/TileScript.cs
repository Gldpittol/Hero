using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Sprite notBroken;
    public Sprite broken;
    public SpriteRenderer sr;


    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void SetBroken()
    {
        sr.sprite = broken;
    }

    public void SetNotBroken()
    {
        sr.sprite = notBroken;
    }
}
