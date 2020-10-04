using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public int currentPattern;

    public GameObject killerPrefab;
    public GameObject player;
    private GameObject temp;

    public bool stopMovement;
    public bool canDoorMove;

    public GameObject sword1;
    public GameObject sword2;
    public GameObject sword3;
    public GameObject sword4;

    public GameObject boss;

    public int spawnedAmount;
    public int pickedAmount;

    void Awake()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
    }


    public void KillPlayer()
    {
        StartCoroutine(DeathDelay());
    }

    public void KillBoss()
    {
        StartCoroutine(BossDeathDelay());
    }


    public void SpawnSword()
    {
        if(spawnedAmount < 4)
        {
            if(currentPattern == 2)
            {
                spawnedAmount++;
                sword1.gameObject.SetActive(true);
            }

            if (currentPattern == 5)
            {
                spawnedAmount++;
                sword2.gameObject.SetActive(true);
            }

            if (currentPattern == 7)
            {
                spawnedAmount++;
                sword3.gameObject.SetActive(true);
            }

            if (currentPattern == 10)
            {
                spawnedAmount++;
                sword4.gameObject.SetActive(true);
            }
        }
    }
    public IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }


    public IEnumerator BossDeathDelay()
    {
        temp = Instantiate(killerPrefab, boss.transform.position, Quaternion.identity);
        temp.transform.localScale = new Vector3(2f, 2f, temp.transform.localScale.z);
        Destroy(boss,1f);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("YouWin", LoadSceneMode.Single);
    }
}
