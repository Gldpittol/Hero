using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public int currentPattern;

    public GameObject killerPrefab;
    public GameObject firePrefab;
    public GameObject player;
    private GameObject temp;


    public bool stopMovement;
    public bool canDoorMove;

    public GameObject sword1;
    public GameObject sword2;
    public GameObject sword3;
    public GameObject sword4;

    public GameObject boss;
    public GameObject bossPrefab;

    public int spawnedAmount;
    public int pickedAmount;

    public bool cannotDie;


    public bool cutsceneMove;


    public AudioSource audSource;
    public AudioClip audClipBigExplosion;
    public AudioClip audClipDoor;
    public AudioClip audClipSword;


    void Awake()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
    }

    private void Update()
    {   if(cutsceneMove && player)
        player.transform.position = Vector2.MoveTowards(player.transform.position, new Vector2(0f, -0.08f), Time.deltaTime);
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

    public void BossHitFunction()
    {
        StartCoroutine(BossHit());
    }
    public IEnumerator BossHit()
    {
        temp = Instantiate(killerPrefab, boss.transform.position, Quaternion.identity);
        temp.transform.localScale = new Vector3(2f, 2f, temp.transform.localScale.z);
        Destroy(temp, 1f);
        yield return new WaitForEndOfFrame();
    }

    public IEnumerator BossDeathDelay()
    {
        temp = Instantiate(killerPrefab, boss.transform.position, Quaternion.identity);
        temp.transform.localScale = new Vector3(2f, 2f, temp.transform.localScale.z);
        Destroy(temp, 1f);
        Destroy(boss, 0.8f);
        StartCoroutine(FinalCutscene());
        yield return new WaitForSeconds(13f);
        SceneManager.LoadScene("YouWin", LoadSceneMode.Single);
    }

    public IEnumerator FinalCutscene()
    {
        cannotDie = true;
        stopMovement = true;
        yield return new WaitForSeconds(2f);
        temp = Instantiate(killerPrefab, player.transform.position, Quaternion.identity);
        Destroy(temp.gameObject, 1f);
        temp = Instantiate(firePrefab, player.transform.position, Quaternion.identity);
        temp.transform.SetParent(player.transform);
        player.GetComponent<SpriteRenderer>().sprite = player.GetComponent<PlayerScript>().downSprite;
        yield return new WaitForSeconds(1f);
        cutsceneMove = true;
        yield return new WaitForSeconds(3f);
        Destroy(temp.gameObject);
        yield return new WaitForSeconds(1f);
        temp = Instantiate(killerPrefab, player.transform.position, Quaternion.identity);
        temp.transform.localScale = new Vector3(2f, 2f, temp.transform.localScale.z);
        PlayAudio("BigExplosion");
        Destroy(temp, 1f);
        Destroy(player.gameObject);
        yield return new WaitForSeconds(0.5f);
        temp = Instantiate(bossPrefab, new Vector2(0f,-0.08f), Quaternion.identity);
        temp.transform.localScale *= -1;
    }


    public void PlayAudio(string audioName)
    {
        switch(audioName)
        {
            case "BigExplosion":
                audSource.PlayOneShot(audClipBigExplosion);
                break;
            case "Door":
                audSource.PlayOneShot(audClipDoor);
                break;
            case "Sword":
                audSource.PlayOneShot(audClipSword);
                break;
        }
    }
}
