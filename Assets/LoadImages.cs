using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class LoadImages : MonoBehaviour {
	public const  int numeroAnimales = 9;
	string url ="images/";
	Texture2D img;
	// Use this for initialization
	void Start () {
	/*	
	  GameObject myPlane = GameObject.Find ("imagen_1");
		Texture2D img = (Texture2D)Resources.Load (url);
		myPlane.GetComponent<Renderer> ().material.mainTexture = img;
		url = "prueba";
		GameObject myPanel = GameObject.Find ("titulo_pergamino_1");
		TextAsset imgPergamino = (TextAsset)Resources.Load (url);
		myPanel.GetComponent<Text>().text = imgPergamino.text;
*/
		string region = "region_"+concurrencia.objConcurrencia.region+"/";

		for (int i = 1; i <= numeroAnimales; i++) {
			// consultar y agregar las imagenes de los animales 
			try{
			string animal = "animal_" + i;
			string urlImagenAnimal = url + region + animal+"/imagen_"+i;
			GameObject imagePlane = GameObject.Find ("imagen_" + i);
			Texture2D img = (Texture2D)Resources.Load (urlImagenAnimal);
			imagePlane.GetComponent<Renderer> ().material.mainTexture = img;

			// Consultar y agregar el titulo (nombre) del animal
			string nombreAnimal ="titulo_" + i;
			string urlNombreAnimal = url + region + animal + "/" + nombreAnimal;
			GameObject panelTitulo = GameObject.Find ("titulo_pergamino_" + i);
			TextAsset tituloPergamino = (TextAsset)Resources.Load (urlNombreAnimal);
			panelTitulo.GetComponent<Text>().text = tituloPergamino.text;

			// Consultar y agregar la descripcion  del animal
			string descripcionAnimal ="descripcion_" + i;
			string urlDescripcionAnimal = url + region + animal + "/" + descripcionAnimal;
			GameObject panelDescripcion = GameObject.Find ("descripcion_pergamino_" + i);
			TextAsset descripcionPergamino = (TextAsset)Resources.Load (urlDescripcionAnimal);
			panelDescripcion.GetComponent<Text>().text = descripcionPergamino.text;
			}catch(Exception e){
				
			}
		}
	}
		//StartCoroutine(LoadImage());

}
