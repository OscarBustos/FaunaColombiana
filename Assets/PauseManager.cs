using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseManager : MonoBehaviour {

	public GameObject[] pauseObjects;

	void Start () {
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
		hidePaused ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (Time.timeScale == 1) {
				Time.timeScale = 0;
				showPaused ();
			} else if (Time.timeScale == 0) {
				Time.timeScale = 1;
				hidePaused();
			}				
		}
	}

	public void pauseControl(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
			showPaused ();
		} else if (Time.timeScale == 0) {
			Time.timeScale = 1;
			hidePaused ();
		}
	}

	public void showPaused(){
		foreach (GameObject g in pauseObjects) {
			g.SetActive (true);
		}
	}

	public void hidePaused(){
		foreach (GameObject g in pauseObjects) {
			g.SetActive (false);
		}
	}

	public void LoadLevel(int scene){
		SceneManager.LoadScene (scene);
	}

	public void quit(){
		Application.Quit();
	}
}
