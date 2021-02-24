using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lapdissolve : MonoBehaviour {
	//I took this from this link:https:/www.youtube.com/watch?v=tBVZzGX9vVo
	public void sahnedegis(int sahneid) //this method is used to change scene with button click
	{
		SceneManager.LoadScene(sahneid);
		
    }

	public void exitGame()
	{
	
		Application.Quit(); 
    }
}
