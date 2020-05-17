using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void btnPlay(){
		SceneManager.LoadScene(0);
	}

	public void btnCredits(){
		SceneManager.LoadScene(1);
	}
}
