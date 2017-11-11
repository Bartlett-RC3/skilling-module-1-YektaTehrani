//Refrences
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
public class Session1 : MonoBehaviour {

	//1.Variables //Lowercase
	// Scope (public and private) -- Type -- Name -- Value

	// Numbers
	public int myFirstIntegerNumber = 98; //make sure you end with ; //type, name ,value
	float myFirstFloatNumber = 1.63f; 

	//Text
	public string myFirstString = "MY Text is somewhere."; //A Variable Can Change

	//Logical variable
	bool MyFirstBoolean = true;

	//Data structures
	//Scope -- Type -- Values

	//3.a.Arrays
	public int[] myIntegerArray = { 1,2,3,4,5 };
	public float[] myFloatArray = new float[5];

	//b.Lists
	public List<int> myIntegerList = new List<int>();

	//2.Functions //Uppercase
	//Scope -- Type -- Variables -- Body (Instructions)
	// Use this for initialization
	void Start () {
		Debug.Log("Addition of 5 and 3 is: " + AdditionOfNumbers(5,3));	
		myFloatArray[2] = 3.2f;
		myFloatArray[4] = 5.6f;
		myFloatArray[1] = 9.2f;

		myIntegerList.Add(1);
		myIntegerList.Add(2);
		myIntegerList.Add (3);

	}

	
	// Update is called once per frame
	void Update () {
		Debug.Log( "Hello world!" );
	}

	int AdditionOfNumbers(int number1, int number2) 
	{
		int additionResult = number1 + number2;
		return additionResult;
	}
