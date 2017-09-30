using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text score;

	void Start(){
		Destroy (GameObject.Find ("GM"));
		//print (PlayerPrefs.GetFloat ("points"));
		float aux = PlayerPrefs.GetFloat ("points");
		score.text = "" + aux;
	}

	// Use this for initialization
	public void Finish (){
		SceneManager.LoadScene ("main");
	}
}
