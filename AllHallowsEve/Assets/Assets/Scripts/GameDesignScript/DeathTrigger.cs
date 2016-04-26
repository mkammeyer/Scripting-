using UnityEngine;
using System.Collections;
// this is script for respawn and death
// also calls move script (jumpScript)
public class DeathTrigger : JumpScript
{ 
	public bool alive = true;
//	bool isGrounded = true;
//	static public bool rotate;
	public MeshRenderer [] death;
	public BoxCollider [] death2;
	public Rigidbody [] death3;

	public GameObject spawnPoint;

	//This if the respawn code from DeathTrigger Code
		void OnTriggerEnter(Collider col)
	{
		if (gameObject.tag == "Player") {
			StartCoroutine (Respawn ());
		}

	}
/*	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "death") 
		{
			alive = false;
		}
	}
*/
	//this is from DeathTrigger code
	IEnumerator Respawn()
	{
		if(gameObject.tag == "Player")
		{
			death = gameObject.GetComponentsInChildren <MeshRenderer>();
			death2 = gameObject.GetComponentsInChildren<BoxCollider>();
			death3 = gameObject.GetComponentsInChildren<Rigidbody>();
			foreach (MeshRenderer mesh in death)
			{
				mesh.enabled = false;
			}
			foreach (BoxCollider mesh in death2)
			{
				mesh.enabled = false;
			}
			yield return new WaitForSeconds(1);

			gameObject.transform.position = (GameObject.FindWithTag("spawn").transform.position);

			foreach(MeshRenderer mesh in death)
				mesh.enabled = true;
			foreach(BoxCollider mesh in death2)
				mesh.enabled = true;

		}
	}


}
