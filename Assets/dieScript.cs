using UnityEngine;
using System.Collections;

public class dieScript : MonoBehaviour {

	public float life = 3;

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "dieCollider"){
			if (life != 0){
			transform.position = new Vector3(0, 30, 0);
			life--;
			}
		else{
			Application.LoadLevel ("scene1");
		}
		}
		
	}
	void OnGUI(){
	GUI.Box (new Rect (0, 0, 100, 45), "Life: " + life);
}
}
