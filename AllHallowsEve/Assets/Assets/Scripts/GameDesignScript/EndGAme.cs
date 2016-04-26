using UnityEngine;
using System.Collections;

public class EndGAme : MonoBehaviour 
{


	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			Application.LoadLevel(2);
		}
	}
}
