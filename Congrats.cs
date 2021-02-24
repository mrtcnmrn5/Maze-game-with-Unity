using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Congrats : MonoBehaviour {

	public string NextLevel;

	void OnTriggerEnter(Collider sph)
	{
	if(sph.gameObject.name == "Ball")
	{
			PlayerPrefs.SetInt(NextLevel, 3);
			SceneManager.LoadScene("LastScene");
		}
    }
}
