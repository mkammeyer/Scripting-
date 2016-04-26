using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour 
{
	public float speed = 10.0f;
	public float jumpSpeed = 7.0f;
	public float maxJump = 1.0f;
	public int jumpCount = 1;
	bool isGrounded =true;
	public Vector3 gravity;
	static public bool rotate;


	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.RightArrow) && rotate == true) 				// Right and Left Turning
			{
				transform.RotateAround (transform.position, transform.up, 180f);
				rotate = false;
			}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && rotate == false) 
			{
				transform.RotateAround (transform.position, transform.up, 180f);
				rotate = true;
			} 
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
		GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;

																				//Jump with Spacbar
		if (Input.GetKeyDown (KeyCode.Space) && maxJump < 3) 
		{
			GetComponent<Rigidbody> ().velocity +=Vector3.up * jumpSpeed;
			jumpCount ++;   
  		}
		if (jumpCount > maxJump || isGrounded == false) 					
		{
			jumpSpeed = 0.0f;
		}
		if (jumpCount > maxJump && isGrounded == true) 
		{
			jumpSpeed = 0.0f;
			jumpCount = 1;
		}
	}

	void OnCollisionEnter (Collision col)			// Restricts jump to only after you touch something that is tagged as Ground
	{
		if (col.gameObject.tag == "Ground") 
		{
			jumpCount = 1;
			jumpSpeed = 7;
		}
	}
}
