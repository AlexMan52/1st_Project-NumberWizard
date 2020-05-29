using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int maxNumber;
    [SerializeField] int minNumber;
    [SerializeField] TextMeshProUGUI guessNumber;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        minNumber = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxNumber = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        if (minNumber <= maxNumber)
        {
            guess = Random.Range(minNumber, maxNumber);
        }
        else minNumber = guess;
        guessNumber.text = guess.ToString();
    }
}
