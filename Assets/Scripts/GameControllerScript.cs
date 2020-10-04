using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    public int currentPattern;

    public GameObject killerPrefab;
    public GameObject player;

    public bool stopMovement;
    public bool canDoorMove;


    void Awake()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 60;
    }
    public void KillPlayer()
    {
        StartCoroutine(DeathDelay());
    }
    public IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}
