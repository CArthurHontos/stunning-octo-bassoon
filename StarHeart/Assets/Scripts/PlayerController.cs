using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb2d;

	public float speed = 1;

	public GameObject bullet;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	void Update()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		//rb2d.AddForce (movement * speed);
		//rb2d.velocity = (movement * speed);
		rb2d.position += (movement * speed);
		if (Input.GetButtonDown("Fire1")) {
			Instantiate (bullet, transform.position, transform.rotation);
		}

	}
}
