using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

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
