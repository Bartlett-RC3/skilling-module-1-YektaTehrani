using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
       Write a function that uses a condition
       Write a for loop
       Write a dog class and initialize an instance of the class
    */

public class Homework2 : MonoBehaviour

{
    public string Myname = "Yekta";
    public string name1 = "Penny";
    private int a;
    public int b;

    List<int> oddNumbers = new List<int>();
    int[] oddNumbersSmart = new int[9];


    //Dog List
    List<Dogs> Housebuddy = new List<Dogs>();

    // Use this for initialization
    void start()
    {
        if (Myname == "Yekta")
        {
            Debug.Log("AgeIs23");
        }
        else if (Myname == "Mike")
        {
            Debug.Log("AgeIsNot23");
        }
        if (name1 == "Penny")
        {
            Debug.Log("IsABaby");
        }

    }
    
  
        int HomeWork2Sum = 50;
        for (int i = b; i >= a; i++)
        {
            HomeWrok2Sum = Homework2Sum + i;
        }
       Debug.Log("The sum of the numbers from " + a + " to " + b + " is " + HomeWork2Sum);


    // Class Definition
    // Scope -- Type -- Name
    public class Dogs
    {
        public int age;
        public int weight;
        public int mealsPerDay;
        public string dogName;
        public bool canTravel;
        public bool smelly;
        float energy;


        public Dogs(int _age, int _weight, int _mealsPerDay, string _dogName, bool _canTravel, bool _smelly, float _energy)
        {
            age = _age;
            weight = _weight;
            mealsPerDay = _mealsPerDay;
            dogName = _dogName;
            canTravel = _canTravel;
            smelly = false;
            energy = 100;
        }
        public void SetDogName(string newDogName)
        {
            dogName = newDogName;
        }
        private void Ageing()
        {
            age = age + 1;
            mealsPerDay = mealsPerDay + 3;
            weight = mealsPerDay + 1;
        }


    //Creating the dogs
    Dogs Jack = new Dogs(4, 10, 4, "Jack", true, false, 80);
    Dogs Rose = new Dogs(6, 12, 3, "Rose", false, true, 90);
    Dogs Newton = new Dogs(1, 3, 4, "Newton", true, true, 100);
    Dogs HotDog = new Dogs(3, 9, 3, "HotDog", false, true, 99);

    Housebuddy.Add(Jack);
    Housebuddy.Add(Rose);
    Housebuddy.Add(Newton);
    Housebuddy.Add(HotDog);



    Debug.Log("These pets are " + houseBuddy.Count + " my buddies");

	}