using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementsScript : MonoBehaviour
{

    public SpriteRenderer sr;
    public Sprite unlockedSprite;

    public string achievementName;


    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        switch (achievementName)
        {
            case "StickIt":
                if (StaticVariables.achievementStickIt >= 1) sr.sprite = unlockedSprite;
                break;

            case "JokingMeNow":
                if (StaticVariables.achievementJokingMeNow >= 1) sr.sprite = unlockedSprite;
                break;

            case "NoWarrior":
                if (StaticVariables.achievementNoWarrior >= 1) sr.sprite = unlockedSprite;
                break;

            case "Steps":
                if (StaticVariables.achievementSteps >= 1) sr.sprite = unlockedSprite;
                break;
            case "YesWarrior":
                if (StaticVariables.achievementYesWarrior >= 1) sr.sprite = unlockedSprite;
                break;

            case "RapidFire":
                if (StaticVariables.achievementRapidFire >= 1) sr.sprite = unlockedSprite;
                break;

        }
    }

}
