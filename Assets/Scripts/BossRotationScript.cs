using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRotationScript : MonoBehaviour
{

    public GameObject player;


    // Update is called once per frame
    void Update()
    {
       if(player) transform.up = player.transform.position - transform.position;
    }
}
