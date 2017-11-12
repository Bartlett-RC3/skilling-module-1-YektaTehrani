//Session 2: Conditions, Loops and Classes
// UCL RC3 12Nov2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2 : MonoBehaviour
{

    //Variable
    public int myNumber = 2;
    public bool questionTime = false;
    int myVariavleQuestionTime;

    string[] fruits = { "banana", "apple", "mango", "blueberrys" };
    List<int> evenNumbers = new List<int>();
    int[] evenNumberSmart = new int[10];

    // Use this for initialization
    void Start()
    {
        // variable name is equal to either 1 or 0 based on the value of questionTime
        myVariavleQuestionTime = (questionTime) ? 1 : 0;
        Debug.Log("The value of myVariableTime is: " + myVariavleQuestionTime);

        //Question concatenation
        if (myNumber == 2 && questionTime == false)
        {
            Debug.Log("Your number is 2 and QT iis false");
        }
        // Question or statement 
        if (myNumber == 2 || questionTime == false)
        {
            Debug.Log("Your number is 2 or it may be that QT is false");
        }

        // Loops
        // For loop statement (starts value, how this ends, incrementation)

        for (int i = 0; i < fruits.Length; i = i + 1)
        {
            Debug.Log("Fruit at position " + i + "is" + fruits[i]);

        }

        for (int i = 0; i < 20; i = i + 2)
        {
            evenNumbers.Add(i);
            evenNumberSmart[i / 2] = i;

        }

        // Print the list
        for (int i = 0; i < evenNumbers.Count; i++)
        {
            Debug.Log("Number is: " + evenNumbers[i]);
        }

        //Add 100 numbers to list and print the numbers that are divisible by 5
        List<int> myOneHunderedNumbers = new List<int>();
        for (int i = 0; i <= 100; i++)
        {
            myOneHunderedNumbers.Add(i);
        }
        // The smart way
        for (int i = 0; i < myOneHunderedNumbers.Count; i = i + 5)
        {
            Debug.Log("Numbers divisible by 5: " + myOneHunderedNumbers[i]);
        }

        //Less smart way

        for (int i = 0; i <= 100; i++)
        {
            if (i % 5 == 0)
            {
                Debug.Log("Numbers divisible by 5: " + myOneHunderedNumbers[i]);
            }
        }

        // While loop
        List<int> oddNumbers = new List<int>();
        int counter = 1;
        while (counter < 100)
        {
            oddNumbers.Add(counter);
            counter = counter + 2;
        }
        for (int i = 0; i < oddNumbers.Count; i++)
        {
            Debug.Log("odd number : " + oddNumbers[i]);
        }


    }

    // Update is called once per frame
    void Update()
    {


    }
}
       
    

