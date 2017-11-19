using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeWork1 : MonoBehaviour
{

    /* 
    //Session 1 homework:
    //Declare a int variable and set a value.
    //Declare a float variable and set a value.
    //Declare a string variable and set a value.
    //Create a function that prints the declared variables.
    //Declare and initialize an array.
    //Declare and initialize a list.
    //Create and initialize a Dictionary.
    */

    //Variables

    //Numbers
    public int IntCodingHomeWorkArray = 5;
    public float FloatCodingHomeWork = 8.0f;

    public int[] codingHomeWorkIntegerArray = new int [2];
    public float[] codingHomeWorkFloatArray = { 2, 5.8f, 14.6f, 92.5f };

    //Text
    public string codingHomeWorkString = "Homework1 is somewhere.";

    //Logical Variable
    public bool codingHomeWorkBool = true;

    //List
    public List<int> codingHomeworkIntegerList = new List<int>();
    public List<string> popularShowsOnNetflix = new List<string>() {"strangerThings", "houseOfCards", "narcos", "crown"};

    //Dictionary
    Dictionary<string, int> ratingOfShowsOnNetflix = new Dictionary<string, int>();

    string[] Genre = new string[] { "mystery", "drama" };

    float CodingHomeworkFunction(float firstVariable, float secondVariable, float thirdVariable)
    {
        float Subtraction = thirdVariable * secondVariable * firstVariable;
        return Subtraction;
    }

    // Arrays
    public int[] homeworkIntegerArray = new int [5];
    public float[] homeworkFloatArray = new float[5];

    //Use this for intialization
    private void Start()
    {
        Debug.Log(codingHomeWorkIntegerArray + "and" + FloatCodingHomeWork + "is" + codingHomeWorkString);

        codingHomeWorkIntegerArray[0] = homeworkIntegerArray[-1] + 1;
        codingHomeworkIntegerList.Add(6);
        codingHomeWorkFloatArray[4] = 14.4f;


        ratingOfShowsOnNetflix.Add("strangerThings", codingHomeWorkIntegerArray[3]);
        ratingOfShowsOnNetflix.Add(popularShowsOnNetflix[2], IntCodingHomeWorkArray);
        ratingOfShowsOnNetflix.Add("Crown", IntCodingHomeWorkArray);

        Debug.Log(ratingOfShowsOnNetflix.Comparer + "areLinkedToThe"+ popularShowsOnNetflix[3]);
        Debug.Log(popularShowsOnNetflix[3] + "is" + ratingOfShowsOnNetflix);
        

    }

    void Update()
    {
        Debug.Log("Hi Unity!");
    }
}
    





