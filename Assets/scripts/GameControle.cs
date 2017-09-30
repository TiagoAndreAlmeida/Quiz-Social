using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControle : MonoBehaviour {

	private List<int> indexOfScenes = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
		11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
	private int[] listOfScenes = new int[9];
	public int currentScene = 0;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
		for (int i = 0; i < 8; i++) {
			int r = Random.Range (0, indexOfScenes.Count - 1);
			listOfScenes [i] = indexOfScenes[r];
			indexOfScenes.RemoveAt(r);
		}
		listOfScenes [8] = 21;
		NextScene ();
	}
	
	// Update is called once per frame
	public void NextScene(){
		SceneManager.LoadScene (listOfScenes [currentScene]);
		currentScene++;
	}
}
