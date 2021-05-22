using UnityEngine;
using System.Collections;

public class walkingEnemy : MonoBehaviour {
	public float speed = 10f;
	public float direction = -1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2 ( speed * direction, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "wall"){
						direction *= -1f;
			}
		}
	}

