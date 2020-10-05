using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariables : MonoBehaviour
{

    public static int currentDialog;
    public static bool started;

    public static int[] vetor = {0,0,0,0,0,0,0,0,0,0};

    public static int achievementStickIt;
    public static int achievementJokingMeNow;
    public static int achievementNoWarrior;
    public static int achievementSteps;
    public static int achievementYesWarrior;
    public static int achievementRapidFire;

    public static int stepCounter;

    public GameObject achievStickIt;
    public GameObject achievJokingMeNow;
    public GameObject achievNoWarrior;
    public GameObject achievSteps;
    public GameObject achievYesWarrior;
    public GameObject achievRapidFire;

    void Start()
    {

        if (!started)
        {
            started = true;
            int rnd1;
            int rnd2;

            for (int i = 0; i < 10; i++)
            {
                vetor[i] = i + 1;
            }
            for(int i = 0; i< 10; i++)
            {

                do
                {
                    rnd1 = Random.Range(0, 10);
                } while (rnd1 == 1 || rnd1 == 4 || rnd1 == 6 || rnd1 == 9);

                do
                {
                    rnd2 = Random.Range(0, 10);
                } while (rnd2 == 1 || rnd2 == 4 || rnd2 == 6 || rnd2 == 9);


                int temp = vetor[rnd1];
                vetor[rnd1] = vetor[rnd2];
                vetor[rnd2] = temp;
            }
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        if(stepCounter > 1000 && achievementSteps == 0 && achievNoWarrior)
        {
            achievementSteps = 1;
            achievSteps.SetActive(true);
        }

        if(achievementNoWarrior == 1 && achievNoWarrior)
        {
            achievementNoWarrior = 2;
            achievNoWarrior.SetActive(true);
        }

        if (achievementStickIt == 1 && achievNoWarrior)
        {
            achievementStickIt = 2;
            achievStickIt.SetActive(true);
        }

        if (achievementYesWarrior == 1 && achievNoWarrior)
        {
            achievementYesWarrior = 2;
            achievYesWarrior.SetActive(true);
        }

        if(currentDialog == 101 && achievNoWarrior && achievementJokingMeNow == 0)
        {
            achievementJokingMeNow = 1;
            achievJokingMeNow.SetActive(true);
        }


        if (achievNoWarrior && achievementRapidFire == 1)
        {
            achievementRapidFire = 2;
            achievRapidFire.SetActive(true);
        }
    }
}
