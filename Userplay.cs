using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Userplay : MonoBehaviour
//I took advantage of Unity's documentation in its site https:/docs.unity3d.com/ScriptReference/index.html
//Unity documentations shows method's syntax and how to use them with a random example 
{

	public float forceCoefficient; //This variable determines how much force will apply to the gameobject
	private Rigidbody rbref; //Rigidbody has to be added to gain solid modelling to the gameobject


	// Use this for initialization
	void Start()
	{
		rbref = GetComponent<Rigidbody>(); // Take this gameobject's rigidbody reference
	}
	//Used for calculations before physical calculations in every frame
	void FixedUpdate()
	{

		rbref.AddForce(Input.GetAxis("Horizontal") * forceCoefficient, 0f, Input.GetAxis("Vertical") * forceCoefficient);
		
	}
}
