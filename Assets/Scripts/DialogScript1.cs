using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogScript1 : MonoBehaviour
{
    public GameControllerScript gc;

    public Text dialogText;
    public Canvas canv;

    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>();
        StartCoroutine(PlayDialog());
    }

    public IEnumerator PlayDialog()
    {


        switch (StaticVariables.currentDialog)
        {
            case 0:
                gc.stopMovement = true;
                dialogText.text = "I never got this far before.";
                yield return new WaitForSeconds(2f);
                dialogText.text = "Time to see what's behind those doors";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 1:
                gc.stopMovement = true;
                dialogText.text = "Why am I here again, what happened?";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 2:
                gc.stopMovement = true;
                dialogText.text = "I fell into the darkness, I should be dead. How am I alive?";
                yield return new WaitForSeconds(3f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 3:
                gc.stopMovement = true;
                dialogText.text = "I wonder if this will ever stop. Am I stuck repeating this over and over forever?";
                yield return new WaitForSeconds(4f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 4:
                gc.stopMovement = true;
                dialogText.text = "Everything seems to be exactly the same every time I do it.";
                yield return new WaitForSeconds(3f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 5:
                gc.stopMovement = true;
                dialogText.text = "It's getting old real fast.";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 6:
                gc.stopMovement = true;
                dialogText.text = "I'm gonna destroy that flamy skull soon, I know it.";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 7:
                gc.stopMovement = true;
                dialogText.text = "Anytime now...";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 8:
                gc.stopMovement = true;
                dialogText.text = "Well...";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 9:
                gc.stopMovement = true;
                dialogText.text = "...";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 20:
                gc.stopMovement = true;
                dialogText.text = "I wonder if this is possible after all...";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 30:
                gc.stopMovement = true;
                dialogText.text = "Please just end this.";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 50:
                gc.stopMovement = true;
                dialogText.text = "#$!#@#$@@#!!#$##";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            case 100:
                gc.stopMovement = true;
                dialogText.text = "You're just shitting me now, right, player-kun? 100 deaths??";
                yield return new WaitForSeconds(2f);
                gc.stopMovement = false;
                Destroy(canv.gameObject);
                break;
            default:
                Destroy(canv.gameObject);
                break;
        }
    }
}
