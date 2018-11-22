﻿using UnityEngine;
using UnityEngine.UI;

public class TrialCountdownScript : MonoBehaviour {
   
    public Text CountdownTime;
    private float timeLeft;
    private int secondsLeft;

    // ********************************************************************** //

    void Update () {

        timeLeft = GameController.control.maxMovementTime - GameController.control.currentMovementTime;
        secondsLeft = (int)Mathf.Round(timeLeft);
        if (GameController.control.displayTimeLeft) 
        {
            if (secondsLeft >= 0)
            {
                CountdownTime.text = (secondsLeft).ToString();
            }
        }

    }
    // ********************************************************************** //

}