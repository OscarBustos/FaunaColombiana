using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadImages : MonoBehaviour {
	string url ="images/Koala";
	Texture2D img;
	// Use this for initialization
	void Start () {
		GameObject myPlane = GameObject.Find ("imagen_1");
		Texture2D img = (Texture2D)Resources.Load (url);
		myPlane.GetComponent<Renderer> ().material.mainTexture = img;
		url = "prueba";
		GameObject myPanel = GameObject.Find ("titulo_pergamino_1");
		TextAsset imgPergamino = (TextAsset)Resources.Load (url);
		myPanel.GetComponent<Text>().text = imgPergamino.text;
	}
		//StartCoroutine(LoadImage());

}
