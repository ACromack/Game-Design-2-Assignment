using UnityEngine;
using System.Collections;

/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerScript : MonoBehaviour
{
	/// <summary>
	/// 1 - The speed of the ship
	/// </summary>
	public Vector2 speed = new Vector2(50, 50);

	// 2 - Store the movement
	private Vector2 movement;

	void Update()
	{
		// 3 - Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		// 4 - Movement per direction
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);


		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 10), ForceMode2D.Impulse);
		}
	}

	void FixedUpdate()
	{
		// 5 - Move the game object
		GetComponent<Rigidbody2D>().velocity = movement;
	}
}