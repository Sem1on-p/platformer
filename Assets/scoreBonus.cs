using UnityEngine;
using System.Collections;

public class scoreBonus : MonoBehaviour {

	public float score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "star") {
			score++;
			Destroy (col.gameObject);
		}
	}
	void OnGUI(){
	GUI.Box (new Rect (0, 55, 100, 45), "Fish: " + score + "\nОсталось: " + (3 - score) );
}
}
