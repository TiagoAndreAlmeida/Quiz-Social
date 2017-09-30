using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//SceneManager.LoadScene ("GameController", LoadSceneMode.Additive);
		PlayerPrefs.SetFloat ("points", 0f);
	}
	public void Iniciar (){
		SceneManager.LoadScene ("GameController", LoadSceneMode.Additive);
	}
}
