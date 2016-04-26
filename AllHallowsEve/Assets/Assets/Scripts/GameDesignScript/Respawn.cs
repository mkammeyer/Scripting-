using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour 
{
	public int startingHealth = 100;
	public int currentHealth;
	public int damageAmount = 20;
//	bool damaged = false;
	
	public GameObject spawnPoint;

	//This is from NewMove
	void OnCollisonEnter(Collision hit)
	{
		if (currentHealth <= 0) 
		{
			this.transform.position = spawnPoint.transform.position;
			currentHealth = startingHealth;
//			healthSlider.value = currentHealth;
		}

	}

	//This if the respawn code from DeathTrigger Code
/*	void OnTriggerEnter(Collider col)
	{
		if (gameObject.tag == "Player") 
		{
			StartCoroutine(Respawn());
		}
	}

	//this is from DeathTrigger code
/*	IEnumerator Respawn()
	{
		if(gameObject.tag == "Player")
		{
			yield return new WaitForSeconds(2);

			gameObject.transform.position = (GameObject.FindGameObjectWithTag("spawn").transform.position);

		}
	}*/
}
