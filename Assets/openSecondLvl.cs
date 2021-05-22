using UnityEngine;
using System.Collections;

public class openSecondLvl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "door"){
			if (!(GameObject.Find("star"))){ 
				Application.LoadLevel ("scene2");			
			}
		}
}
}
