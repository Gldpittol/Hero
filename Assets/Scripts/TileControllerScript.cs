using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileControllerScript : MonoBehaviour
{
    public GameObject[] tiles;

    public int currentPattern;

    public float fadeTime;

    private void Start()
    {
        currentPattern = 1;
    }

    void Update()
    {

        switch(currentPattern)
        {
            case 1:
                currentPattern = 5000;
                StartCoroutine(Pattern1());
                break;

            case 2:
                currentPattern = 5000;
                StartCoroutine(Pattern2());
                break;

        }
    }

    public IEnumerator Pattern1()
    {
        yield return new WaitForSeconds(1f);
        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, 3f);
        yield return new WaitForSeconds(1f);
        tiles[2].GetComponent<FadeScript>().FadeStart(fadeTime, 3f);
        tiles[3].GetComponent<FadeScript>().FadeStart(fadeTime, 3f);
        yield return new WaitForSeconds(1f);
        tiles[4].GetComponent<FadeScript>().FadeStart(fadeTime, 3f);

        currentPattern = 2;
    }


    public IEnumerator Pattern2()
    {
        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, 3f);
        yield return new WaitForSeconds(1f);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, 3f);
        yield return new WaitForSeconds(1f);
        tiles[23].GetComponent<FadeScript>().FadeStart(fadeTime, 3f);
        tiles[33].GetComponent<FadeScript>().FadeStart(fadeTime, 3f);
        yield return new WaitForSeconds(1f);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, 3f);

        currentPattern = 1;
    }
}
