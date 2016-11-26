using UnityEngine;
using System.Collections;

public class concurrencia : MonoBehaviour {

	public int region {get; set;}
	public static concurrencia objConcurrencia;
	void Awake(){
		if (objConcurrencia == null) {
			objConcurrencia = this;
			DontDestroyOnLoad (gameObject);
		} else if(objConcurrencia != this){
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
