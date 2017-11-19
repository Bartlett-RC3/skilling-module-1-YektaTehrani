using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session01_Homework : MonoBehaviour
{

    /* Session 1 homework:
    Declare a int variable and set a value
    Declare a float variable and set a value
    Declare a string variable and set a value
    Create a function that prints the declared variables
    Declare and initialize an array
    Declare and initialize a list
    Create and initialize a Dictionary */

    //Numbers
    public int codingHomeworkInteger = 5;
    public float codingHomeworkFloat = 82.3f;

    //Text
    public string codingHomeworkString = "First HomeWork is?";

    //Array
    public int[] codingHomeworkIntegerArray = new int[6];
    public float[] codingHomeworkFloatArray = { 2, 6f, 18.6f, 86.8f, 78.6f };

    //List
    public List<int> codingHomeworkIntegerList = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    public List<string> popularShowsOnNetflix = new List<string>() { "strangerThings", "houseOfCards", "narcos", "crown" };

    //Dictionary
    Dictionary<string, int> ratingOfShowsOnNetflix = new Dictionary<string, int>();


    float codingHomeworkFunction(float firstVariable, float secondVariable, float thirdVariable)
    {
        float Subtraction = thirdVariable - secondVariable - firstVariable;
        return Subtraction;
    }


    // Use this for initialization
    void Start()
    {

        Debug.Log(codingHomeworkString + "is" + codingHomeworkFloat + "and" + codingHomeworkInteger);

        codingHomeworkFloatArray[4] = 78.6f;
        codingHomeworkIntegerArray[0] = codingHomeworkIntegerArray[-1] + 1;
        codingHomeworkIntegerList.Add(5);
        codingHomeworkIntegerList.Add(23);

        ratingOfShowsOnNetflix.Add(popularShowsOnNetflix[3], codingHomeworkInteger);
        ratingOfShowsOnNetflix.Add(popularShowsOnNetflix[0], codingHomeworkInteger);
        ratingOfShowsOnNetflix.Add("strangerThings", codingHomeworkIntegerArray[2]);
        ratingOfShowsOnNetflix.Add("crown", codingHomeworkInteger);


        Debug.Log(popularShowsOnNetflix[0] + "is" + ratingOfShowsOnNetflix[popularShowsOnNetflix[0]]);
        Debug.Log(ratingOfShowsOnNetflix.Comparer + popularShowsOnNetflix[4]);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hi Unity Homework!");
    }
}