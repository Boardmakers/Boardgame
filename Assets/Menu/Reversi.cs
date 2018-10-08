using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reversi : MonoBehaviour {

	void Start(){
		gameObject.SetActive(false);
	}

	// Use this for Move Scene
	public void GameStart(){
		SceneManager.LoadScene("Reversi");		
	}



}
