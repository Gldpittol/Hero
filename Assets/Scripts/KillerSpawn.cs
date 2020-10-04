using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerSpawn : MonoBehaviour
{
    public GameControllerScript gc;
    public Vector3 tempTransform;
    public bool canSpawn;

    private GameObject temp;

    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
        canSpawn = true;
    }

    void Update()
    {
        if(gc.currentPattern != 1 && gc.currentPattern != 2 && gc.currentPattern !=8 && canSpawn)
        {
            canSpawn = false;
            StartCoroutine(SpawnKiller());
        }
    }


    public IEnumerator SpawnKiller()
    {
        if(gc.player) tempTransform = gc.player.transform.position;
        yield return new WaitForSeconds(2f);
        temp = Instantiate(gc.killerPrefab, tempTransform, Quaternion.identity);
        Destroy(temp, 1f);
        canSpawn = true;
    }
}
