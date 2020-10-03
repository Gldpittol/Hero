using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private GameControllerScript gc;

    private SpriteRenderer sr;
    public Sprite upSprite;
    public Sprite downSprite;
    public Sprite rightSprite;
    public Sprite leftSprite;

    private bool canMove;
    public float waitTime;

    void Start()
    {
        canMove = true;
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && canMove && transform.position.y < 0.63f)
        {
            canMove = false;
            sr.sprite = upSprite;
            gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + 0.16f);
            StartCoroutine(MoveDelay());
        }

        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && canMove && transform.position.y > -0.79f)
        {
            canMove = false;
            sr.sprite = downSprite;
            gameObject.transform.position = new Vector2(transform.position.x, transform.position.y - 0.16f);
            StartCoroutine(MoveDelay());
        }

        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && canMove && transform.position.x > -0.70f)
        {
            canMove = false;
            sr.sprite = leftSprite;
            gameObject.transform.position = new Vector2(transform.position.x - 0.16f, transform.position.y);
            StartCoroutine(MoveDelay());
        }

        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && canMove && transform.position.x < 0.71f)
        {
            canMove = false;
            sr.sprite = rightSprite;
            gameObject.transform.position = new Vector2(transform.position.x + 0.16f, transform.position.y);
            StartCoroutine(MoveDelay());
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Death"))
        {
            Destroy(this.gameObject);
        }
    }

    public IEnumerator MoveDelay()
    {
        yield return new WaitForSeconds(waitTime);
        canMove = true;
    }
}
