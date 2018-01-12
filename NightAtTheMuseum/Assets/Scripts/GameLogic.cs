using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoToScene(string SceneName) {
		Debug.Log ("My method was called.");
		SceneManager.LoadScene (SceneName);
	}
}
