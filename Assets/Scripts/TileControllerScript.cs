using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileControllerScript : MonoBehaviour
{
    public GameObject[] tiles;

    public int currentPattern;

    private void Start()
    {
        currentPattern = 1;
    }

    void Update()
    {
        if(currentPattern == 1)
        {
            currentPattern = 2;
            StartCoroutine(Pattern1());
        }
    }

    public IEnumerator Pattern1()
    {
        yield return new WaitForSeconds(1f);
        tiles[1].GetComponent<FadeScript>().FadeStart(0.2f, 3f);
        yield return new WaitForSeconds(1f);
        tiles[2].GetComponent<FadeScript>().FadeStart(0.2f, 3f);
        tiles[3].GetComponent<FadeScript>().FadeStart(0.2f, 3f);
        yield return new WaitForSeconds(1f);
        tiles[4].GetComponent<FadeScript>().FadeStart(0.2f, 3f);
    }
}
