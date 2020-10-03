using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour
{

    public float fadeDuration;
    public float i = 1;

    private SpriteRenderer sr;

    public bool fadeOut;
    public bool fadeIn;

    public TileScript ts;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ts = GetComponent<TileScript>();
    }

    public void FadeStart(float timeFade, float timeWait)
    {
        StopAllCoroutines();
        StartCoroutine(ToFade(timeFade, timeWait));
    }

    private void Update()
    {
       
        if(fadeOut)
        {
            if (i >= 0)
            {
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, i);
                i -= Time.deltaTime / fadeDuration;
            }
            else
            {
                gameObject.tag = "Death";
                fadeOut = false;
            }
        }
     




        if(fadeIn)
        {
            if (i <= 0)
            {
                gameObject.tag = "NonDeath";
            }

            if (i <= 1)
            {
                sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, i);
                i += Time.deltaTime / fadeDuration;
            }

            else
            {
                fadeIn = false;
            }
        }
       

    }

    public IEnumerator ToFade(float fadeDur, float waitToFadeIn)
    {
        fadeDuration = fadeDur;
        ts.SetBroken();
        fadeOut = true;
        yield return new WaitForSeconds(waitToFadeIn);
        ts.SetNotBroken();
        fadeIn = true;
    }

}