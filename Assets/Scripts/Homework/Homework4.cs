using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
Create a cube prefab that has a script attached to it.
Write a change colour coroutine.
Create a cube array and change destroy them in play mode using ray casting.
*/
public class Homework4 : MonoBehaviour {


    //Var
    public GameObject spherePrefab;
    IEnumerator createSphereCoroutine;
    
    


    public Color sphereColor;
    public Material sphereMaterial;



    // Use this for initialization
    void Start ()
    {
        createSphereCoroutine = ColorSpheres();
        StartCoroutine(createSphereCoroutine);
    }
	
	// Update is called once per frame
	void Update ()
    {
        
        Debug.Log(Time.time);
        if (Time.time > 2)
        {
            StopCoroutine(createSphereCoroutine);
            StopAllCoroutines();
        }

    }

    //Coroutine 
   // IEnumerator ColorSpheres()
   // {
        
       /* while (true)
        {
            Vector3 spherePosition = new Vector3(-5f,8f,6f);
            Quaternion sphereRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
            GameObject newSphere = Instantiate(spherePrefab, spherePosition, sphereRotation);
            if (Time.time > 2)
            {
                StopAllCoroutines();
            }
            yield return new WaitForSeconds(1);
        
        } */
    //}
}
