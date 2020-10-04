using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    public int side;
    public GameControllerScript gc;
    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
    }
    void Update()
    {
        if(gc.canDoorMove)
        {
            transform.position = new Vector3(transform.position.x + side * Time.deltaTime * 0.3f, transform.position.y, transform.position.z);
            Destroy(this.gameObject, 2f);
        }
    }
}
