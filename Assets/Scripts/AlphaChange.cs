using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaChange : MonoBehaviour
{
    public SpriteRenderer sr;
    public SpriteRenderer daddyRenderer;
    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
       
        daddyRenderer = this.transform.parent.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        sr.color = daddyRenderer.color;
    }
}
