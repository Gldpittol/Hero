using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileControllerScript : MonoBehaviour
{
    public GameObject[] tiles;

    public int currentPattern;


    private void Start()
    {
        currentPattern = 8;
    }

    void Update()
    {

        switch (currentPattern)
        {
            case 1:
                currentPattern = 5000;
                StartCoroutine(Pattern1());
                break;

            case 2:
                currentPattern = 5000;
                StartCoroutine(Pattern2());
                break;

            case 3:
                currentPattern = 5000;
                StartCoroutine(Pattern3());
                break;

            case 4:
                currentPattern = 5000;
                StartCoroutine(Pattern4());
                break;

            case 5:
                currentPattern = 5000;
                StartCoroutine(Pattern5());
                break;

            case 6:
                currentPattern = 5000;
                StartCoroutine(Pattern6());
                break;

            case 7:
                currentPattern = 5000;
                StartCoroutine(Pattern7());
                break;

            case 8:
                currentPattern = 5000;
                StartCoroutine(Pattern8());
                break;
        }
    }

    public IEnumerator Pattern1()
    {
        //diagonal do noroeste para o sudeste
        float fadeTime = 0.1f;
        float returnTime = 5f;
        float waitTime = 0.1f;

        yield return new WaitForSeconds(waitTime);
        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[2].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[11].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[3].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[12].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[21].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[4].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[13].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[22].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[31].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[5].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[14].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[23].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[32].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[41].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[6].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[24].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[33].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[51].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[7].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[16].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[25].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[34].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[43].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[52].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[61].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[8].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[17].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[26].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[35].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[44].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[53].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[62].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[71].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[9].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[18].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[27].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[36].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[54].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[63].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[72].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[81].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[10].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[19].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[28].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[37].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[64].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[73].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[82].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[91].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[20].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[29].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[38].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[47].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[65].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[74].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[83].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[92].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[30].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[39].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[48].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[57].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[66].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[75].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[84].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[93].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[40].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[49].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[58].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[67].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[76].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[85].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[94].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[50].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[59].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[68].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[77].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[86].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[95].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[60].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[69].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[78].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[87].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[96].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[70].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[79].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[88].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[97].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[80].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[89].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[98].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[90].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[99].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(10f);


        currentPattern = 2;
    }

    public IEnumerator Pattern2()
    {
        //wipe da esquerda para a direita, depois de cima para baixo restando 1 tile
        float fadeTime = 0.1f;
        float returnTime = 5f;
        float waitTime = 0.1f;

        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[11].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[21].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[31].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[41].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[51].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[61].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[71].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[81].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[91].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[2].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[12].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[22].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[32].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[52].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[62].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[72].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[82].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[92].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[3].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[13].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[23].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[33].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[43].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[53].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[63].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[73].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[83].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[93].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[4].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[14].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[24].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[34].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[44].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[54].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[64].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[74].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[84].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[94].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[5].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[25].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[35].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[65].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[75].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[85].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[95].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[6].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[16].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[26].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[36].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[66].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[76].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[86].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[96].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[7].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[17].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[27].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[37].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[47].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[57].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[67].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[77].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[87].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[97].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[8].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[18].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[28].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[38].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[48].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[58].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[68].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[78].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[88].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[98].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[9].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[19].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[29].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[39].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[49].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[59].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[69].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[79].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[89].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[99].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(0.3f);
        tiles[100].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2.7f);
        yield return new WaitForSeconds(0.3f);
        tiles[90].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2.4f);
        yield return new WaitForSeconds(0.3f);
        tiles[80].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2.1f);
        yield return new WaitForSeconds(0.3f);
        tiles[70].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 1.8f);
        yield return new WaitForSeconds(0.3f);
        tiles[60].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 1.5f);
        yield return new WaitForSeconds(0.3f);
        tiles[50].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 1.2f);
        yield return new WaitForSeconds(0.3f);
        tiles[40].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 0.9f);
        yield return new WaitForSeconds(0.3f);
        tiles[30].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 0.6f);
        yield return new WaitForSeconds(0.3f);
        tiles[20].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 0.3f);
        yield return new WaitForSeconds(10f);

        currentPattern = 3;
    }

    public IEnumerator Pattern3()
    {
        //concêntrico, sobrando um quadrado de tiles no meio
        float fadeTime = 0.1f;
        float returnTime = 5f;
        float waitTime = 0.1f;

        yield return new WaitForSeconds(waitTime);
        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[2].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[3].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[4].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[5].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[6].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[7].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[8].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[9].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[10].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[11].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[21].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[31].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[41].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[51].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[61].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[71].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[81].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[91].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[92].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[93].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[94].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[95].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[96].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[97].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[98].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[99].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[20].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[30].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[40].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[50].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[60].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[70].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[80].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[90].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[100].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[12].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[13].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[14].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[16].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[17].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[18].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[19].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[22].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[32].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[52].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[62].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[72].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[82].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[71].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[81].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[82].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[83].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[84].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[85].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[86].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[87].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[88].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[89].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[29].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[39].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[49].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[59].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[69].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[79].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[89].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(waitTime);
        tiles[34].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[35].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[36].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[37].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[44].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[47].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[54].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[57].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[64].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[65].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[66].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[67].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(10f);


        currentPattern = 4;
    }

    public IEnumerator Pattern4()
    {
        //retira os corredores centrais e depois os quadrados nordeste e sudoeste
        float fadeTime = 0.1f;
        float returnTime = 5f;
        float waitTime = 0.1f;

        yield return new WaitForSeconds(waitTime);
        tiles[5].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[6].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[16].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[25].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[26].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[35].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[36].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[65].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[66].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[75].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[76].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[85].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[86].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[95].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[96].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[41].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[43].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[44].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[47].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[48].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[49].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[51].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[52].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[53].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[54].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[57].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[58].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[59].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[60].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[50].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(2f);
        tiles[7].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[8].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[9].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[10].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[17].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[18].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[19].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[20].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[27].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[28].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[29].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[30].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[37].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[38].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[39].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[40].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[61].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[62].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[63].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[64].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[71].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[72].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[73].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[74].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[81].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[82].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[83].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[84].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[91].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[92].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[93].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[94].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(10f);




        currentPattern = 5;

    }

    public IEnumerator Pattern5()
    {
        //retira os corredores centrais e depois os quadrados noroeste e sudeste
        float fadeTime = 0.1f;
        float returnTime = 5f;
        float waitTime = 1f;

        yield return new WaitForSeconds(waitTime);
        tiles[5].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[6].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[16].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[25].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[26].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[35].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[36].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[65].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[66].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[75].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[76].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[85].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[86].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[95].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[96].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[41].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[43].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[44].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[47].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[48].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[49].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[51].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[52].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[53].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[54].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[57].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[58].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[59].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[60].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[50].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(2f);
        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[2].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[3].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[4].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[11].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[12].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[13].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[14].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[21].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[22].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[23].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[24].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[31].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[32].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[33].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[34].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[67].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[68].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[69].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[70].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[77].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[78].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[79].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[80].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[87].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[88].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[89].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[90].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[97].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[98].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[99].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        tiles[100].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime - 2f);
        yield return new WaitForSeconds(10f);

        currentPattern = 6;

    }

    public IEnumerator Pattern6()
    {
        //rotação horário
        float fadeTime = 0.1f;
        float returnTime = 5f;
        float waitTime = 1f;
                        
        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[41].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[43].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[44].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[51].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[52].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[53].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[54].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[2].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[3].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[4].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[11].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[12].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[13].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[14].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[21].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[22].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[23].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[24].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[31].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[32].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[33].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[34].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[5].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[6].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[16].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[25].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[26].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[35].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[36].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[7].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[8].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[9].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[10].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[17].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[18].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[19].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[20].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[27].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[28].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[29].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[30].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[37].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[38].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[39].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[40].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[47].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[48].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[49].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[50].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[57].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[58].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[59].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[60].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[67].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[68].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[69].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[70].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[77].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[78].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[79].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[80].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[87].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[88].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[89].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[90].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[97].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[98].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[99].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[100].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[65].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[66].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[75].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[76].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[85].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[86].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[95].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[96].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[61].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[62].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[63].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[64].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[71].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[72].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[73].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[74].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[81].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[82].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[83].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[84].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[91].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[92].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[93].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[94].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[41].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[43].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[44].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[51].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[52].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[53].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[54].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[2].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[3].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[4].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[11].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[12].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[13].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[14].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[21].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[22].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[23].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[24].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[31].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[32].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[33].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[34].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[5].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[6].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[16].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[25].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[26].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[35].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[36].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[7].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[8].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[9].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[10].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[17].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[18].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[19].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[20].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[27].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[28].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[29].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[30].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[37].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[38].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[39].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[40].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[47].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[48].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[49].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[50].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[57].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[58].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[59].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[60].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[67].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[68].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[69].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[70].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[77].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[78].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[79].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[80].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[87].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[88].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[89].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[90].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[97].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[98].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[99].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[100].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[65].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[66].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[75].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[76].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[85].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[86].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[95].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[96].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[61].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[62].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[63].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[64].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[71].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[72].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[73].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[74].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[81].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[82].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[83].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[84].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[91].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[92].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[93].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[94].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        yield return new WaitForSeconds(10f);


        //for (int i = 1; i <= 40; i++)
        //{
        //tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);         
        // }
        currentPattern = 7;
    }

    public IEnumerator Pattern7()
    {
        //rotação antihorário
        float fadeTime = 0.1f;
        float returnTime;
        float waitTime = 1f;

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[47].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[48].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[49].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[50].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[57].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[58].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[59].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[60].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[7].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[8].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[9].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[10].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[17].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[18].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[19].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[20].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[27].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[28].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[29].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[30].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[37].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[38].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[39].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[40].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[5].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[6].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[16].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[25].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[26].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[35].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[36].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[2].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[3].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[4].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[11].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[12].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[13].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[14].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[21].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[22].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[23].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[24].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[31].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[32].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[33].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[34].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[41].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[43].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[44].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[51].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[52].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[53].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[54].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[61].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[62].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[63].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[64].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[71].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[72].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[73].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[74].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[81].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[82].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[83].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[84].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[91].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[92].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[93].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[94].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[65].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[66].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[75].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[76].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[85].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[86].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[95].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[96].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[67].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[68].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[69].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[70].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[77].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[78].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[79].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[80].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[87].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[88].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[89].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[90].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[97].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[98].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[99].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[100].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[47].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[48].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[49].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[50].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[57].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[58].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[59].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[60].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[7].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[8].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[9].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[10].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[17].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[18].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[19].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[20].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[27].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[28].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[29].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[30].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[37].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[38].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[39].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[40].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[5].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[6].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[15].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[16].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[25].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[26].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[35].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[36].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[1].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[2].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[3].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[4].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[11].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[12].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[13].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[14].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[21].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[22].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[23].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[24].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[31].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[32].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[33].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[34].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[41].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[42].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[43].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[44].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[51].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[52].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[53].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[54].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[61].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[62].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[63].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[64].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[71].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[72].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[73].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[74].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[81].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[82].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[83].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[84].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[91].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[92].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[93].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[94].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[65].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[66].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[75].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[76].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[85].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[86].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[95].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[96].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        tiles[67].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[68].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[69].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[70].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[77].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[78].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[79].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[80].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[87].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[88].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[89].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[90].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[97].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[98].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[99].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
        tiles[100].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);

        currentPattern = 0;


    }

    public IEnumerator Pattern8()
    {
        //rotação antihorário
        float fadeTime = 0.1f;
        float returnTime;
        float waitTime = 1f;

        yield return new WaitForSeconds(waitTime);
        returnTime = 5f;
        
        for (int i = 1; i < 10; i++)
        {
        tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
            i++;
        }
        for (int i = 12; i < 21; i++)
        {
            tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
            i++;
        }
        for (int i = 21; i < 31; i++)
        {
            tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
            i++;
        }
        for (int i = 32; i < 41; i++)
        {
            tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
            i++;
        }
        for (int i = 41; i < 51; i++)
        {
            if (i == 45)
            {
                i++;                
            }
            else
            {
                tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
                i++;
            }
        }
        for (int i = 52; i < 61; i++)
        {
            if (i == 56)
            {
                i++;                
            }
            else
            {
                tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
                i++;
            }
        }
        for (int i = 61; i < 71; i++)
        {
            tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
            i++;
        }
        for (int i = 72; i < 81; i++)
        {
            tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
            i++;
        }
        for (int i = 81; i < 91; i++)
        {
            tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
            i++;
        }
        for (int i = 92; i < 101; i++)
        {
            tiles[i].GetComponent<FadeScript>().FadeStart(fadeTime, returnTime);
            i++;
        }
    }

}
        