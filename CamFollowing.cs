using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowing : MonoBehaviour
{
	public GameObject BallRef; //add reference to the gameobject

	private Vector3 CameraBallDistance; //Shows distance between gameobject and camera

	// Use this for initialization
	void Start()
	{
		CameraBallDistance = transform.position - BallRef.transform.position;
		//To find distance,camera's position must be substracted from gameobject's position
	}

	//Used after all other update's operation is over
	void LateUpdate()
	{
		transform.position = BallRef.transform.position + CameraBallDistance;
		//When gameobject changes its position,its position must be added to distance
	}

}
