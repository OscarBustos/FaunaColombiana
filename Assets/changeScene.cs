using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class changeScene : MonoBehaviour {

	public void changeToScene(int region){

		concurrencia.objConcurrencia.region = region;
		SceneManager.LoadScene (1); 
	}
}
