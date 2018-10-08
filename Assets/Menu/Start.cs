using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {

	// Use this for Move Scene
	public void GameStart(){
		gameObject.SetActive(false);
		Canvas.SetActive("Reversi", true);
		Canvas.SetActive("Chess", true);
	}


}
