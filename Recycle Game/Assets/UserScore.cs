using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class UserScore : AbstractSingleton<UserScore>
{
    private int userScore;
    public TextMeshProUGUI scoreText;

    public int UserScoreProperty
    {
        get
        {
            return userScore;
        }
        set
        {
            userScore = value;
            scoreText.text = UserScoreProperty.ToString();
        }
    }

    // Start is called before the first frame update
    public void Start()
    {
        UserScoreProperty = 0;
    }

    public void AddPoints(int pointValue)
    {
        UserScoreProperty += pointValue;
    }
}
