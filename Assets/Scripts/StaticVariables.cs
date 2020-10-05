using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariables : MonoBehaviour
{

    public static int currentDialog;
    public static bool started;

    public static int[] vetor = {0,0,0,0,0,0,0,0,0,0};
    

    
    void Start()
    {
        if(!started)
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
        
    }
}
