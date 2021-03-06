﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework3 : MonoBehaviour {


    /*
    Create a cube and move it across the screen
    Create a cube and change its colour when key is pressed or mouse is pressed
    Add a script to a game object
   */

    // Variables
    int counter = 0;
    public GameObject cubeReference;
    bool moveUp = true;
    bool moveDown = false;
    public Color cubeColor;
    public Material cubeMaterial;
    

    // Use this for initialization
    void Start () {

        cubeMaterial.color = Color.blue;
        
    }

    // Update is called once per frame
    // Moving Cube Up and Down
    void Update()
    {
        if (moveUp == true)
        {
            if (counter <= 10)
            {
                gameObject.transform.Translate(Vector3.up);
                counter++;
            }
            else
            {
                moveUp = false;
                moveDown = true;
                counter = 0;
            }
        }
        if (moveDown == true)
        {
            if (counter <= 10)
            {
                gameObject.transform.Translate(Vector3.down);
                counter++;
            }
            else
            {
                moveUp = true;
                moveDown = false;
                counter = 0;
            }
        }
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            //Changing cube color with space button (blue to yellow)

            if (cubeMaterial.color == Color.blue)
            {
                cubeMaterial.color = Color.yellow;
            }
            else
            {
                cubeMaterial.color = Color.blue;
            }
        }
    }
}

