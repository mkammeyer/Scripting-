using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour 
{
	/* Emun list varibles
 * switch powers up (speed, double jump, points)
 * loops
 * jamesplusgames (youtube)
*/
	//public bool PickUpActive;
	public Sprite [] sprite;
	public GameObject pickup;
	public GameObject scoreCounter;
	public int scoreValue = 20;

	public enum CandyType
	{
		Candy,
		Lolly,
		Apple,
	}

	public CandyType candyType;

	void Start () 
	{

	}
	

	void CandySwitch ()                 //FixedUpdate () 
	{
		switch (candyType) 
		{
		case CandyType.Candy: 
			GetComponent<SpriteRenderer>().sprite = sprite[0];
			//Destroy(this.gameObject);
			break;
		case CandyType.Lolly:
			GetComponent<SpriteRenderer>().sprite = sprite[1];
			//Destroy(this.gameObject);
			break;
		case CandyType.Apple:
			GetComponent<SpriteRenderer>().sprite = sprite[2];
			//Destroy(this.gameObject);
			break;
		default:
			print("You haven't found any candy yet");
				break;
		}
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log("pick up");
		if (other.gameObject == pickup) 
		{
			ScoreManager.score += scoreValue;
			DestroyObject(pickup);
			Debug.Log("pickup here");
		}
	}
		
/*		void OnCollision (Collider other)
	{
		Debug.Log ("OnTriggerEnter");

		if (other.gameObject.CompareTag ("PickUp")) 
		{
			BoxCollider thisCollider = gameObject.GetComponent<BoxCollider>();
			SpriteRenderer thisSprite = gameObject.GetComponent<SpriteRenderer>();
			//other.gameObject.SetActive(false);
			thisCollider.enabled = ! thisCollider.enabled;
			thisSprite.enabled = ! thisSprite.enabled;
			Debug.Log("In if statement");
		}
	}*/
}
			                                               
			                                              