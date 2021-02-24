using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinningLevel : MonoBehaviour {

	public string NextLevel;
	

	void OnTriggerEnter(Collider sph) //This method is used when objects collide
	{
	if(sph.gameObject.name == "Ball")
	{
			PlayerPrefs.SetInt(NextLevel, 2);
			SceneManager.LoadScene("Level2");
    }

	
    }

	
}
