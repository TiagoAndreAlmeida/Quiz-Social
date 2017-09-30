using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour {
	private CanvasScaler cv;
	private GameControle gm;

	void Start(){
		gm = GameObject.Find ("GM").GetComponent<GameControle> ();
		cv = GetComponent<CanvasScaler> ();
		cv.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		cv.referenceResolution = new Vector2 (540, 960);
	}

	public void res1 () {
		float aux = PlayerPrefs.GetFloat ("points");
		aux = aux + 12.5f;
		PlayerPrefs.SetFloat ("points", aux);
		gm.NextScene ();
	}

	public void res2 () {
		float aux = PlayerPrefs.GetFloat ("points");
		aux = aux + 0.0625f;
		PlayerPrefs.SetFloat ("points", aux);
		gm.NextScene ();
	}

	public void res3 () {
		float aux = PlayerPrefs.GetFloat ("points");
		aux = aux + 0.03125f;
		PlayerPrefs.SetFloat ("points", aux);
		gm.NextScene ();
	}

}
