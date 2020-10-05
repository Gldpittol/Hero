using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOutScriptImage : MonoBehaviour
{

    public float fadeDuration;
    private float i = 1;

    public bool fadeStart;

    private Image img;

    private void Start()
    {
        fadeStart = true;
        img = GetComponent<Image>();
    }

    void Update()
    {
        if (fadeStart)
        {
            if (i >= 0)
            {
                img.color = new Color(img.color.r, img.color.g, img.color.b, i);
                i -= Time.deltaTime / fadeDuration;
            }
            else Destroy(this.gameObject);
        }
    }

}