using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    //creates 3 number variables
    int min = 1;
    int max = 1000;
    int guess = 500;

    void NextGuess()
    {
        print("Is the number greater or smaller than " + guess + "?");
        print("UP: Greater DOWN: Smaller ENTER: Equal");
    }

    void StartGame()
    {
        //prints once in the console
        //print and Debug.Log is the same
        print("Welcome to Number Wizard");
        Debug.Log("Please choose a number in your head between " + min + " and " + max);
        //calling method NextGuess()
        NextGuess();
    }
    // Use this for initialization
    void Start() {
        StartGame();
    }

    // Update is called once per frame
    void Update () {
        //if the input from the keyboard is up arrow
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UP Arrow Pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        else

        //if the input from the keyboard is down arrow
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DOWN Arrow Pressed");
            max = guess;
            guess = (min + max) / 2;
            NextGuess();
        }

        else

        //if the input from the keyboard is enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ENTER Pressed");
            print("I GUESSED IT!! The Number was " +guess+" :)");
        }
    }
}
