using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameManager : MonoBehaviour
{
    private int _currentScore;
    public static MainGameManager instance;

    void Awake() 
    {
        // creates an instance of the object with this script attached.
        instance = this;
    }

    public void AdjustScore(int num)
    {
        // calculates the current score
        _currentScore = _currentScore + num;
    }

    private void OnGUI() 
    {
        // Prints the label on the screen with the word "score" + the calculated score
        GUI.Label(new Rect(10, 10, 100, 100), "Score = " + _currentScore);
    }
    
}
