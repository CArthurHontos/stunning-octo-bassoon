using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private Rigidbody2D rb2d;

	public float speed = 1;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		Vector2 movement = new Vector2 (speed, 0);
		rb2d.velocity = movement;
	}

	void OnBecameInvisible () {
		//Destroy self
	}

	void OnCollisionEnter2D () {
		//doot that damage!
	}

}
