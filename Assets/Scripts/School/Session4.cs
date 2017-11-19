using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4 : MonoBehaviour {

    //Variable
    public GameObject coloumnPrefab;
    IEnumerator createColoumnCoroutin;

	// Use this for initialization
	void Start () {

         
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Coroutines
    IEnumerator DropColoumns()
    {
       yield return new WaitForSeconds(5);
        Vector3 columnPosition = new Vector3(Random.Range(-5f,3f), Random.Range(8f,15f), Random.Range(-7f,0f));
        Quaternion coloumnRotation = new Quaternion(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90), 1);
       
    }
}
