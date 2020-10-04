using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    public int side;
    public int vertical;
    public GameControllerScript gc;

    public bool soundPlayed;
    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
    }
    void Update()
    {
        if(gc.canDoorMove)
        {
            transform.position = new Vector3(transform.position.x + side * Time.deltaTime * 0.3f, transform.position.y + vertical * Time.deltaTime * 0.3f, transform.position.z);

            if(!soundPlayed)
            {
                soundPlayed = true;
                gc.PlayAudio("Door");
                Destroy(this.gameObject, 2f);

            }
        }
    }
}
