using UnityEngine;
using System.Collections;

public class RestartGame : MonoBehaviour 
{
	public float health;
	public GameObject Player;

	public void TakeDamage (float dmg)
	{
		health = dmg;


		if (health <= 0) 
		{
			Die();
		}
	}

	public void Die()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

}
