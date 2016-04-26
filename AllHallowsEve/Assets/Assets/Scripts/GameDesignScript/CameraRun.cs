using UnityEngine;
using System.Collections;

public class CameraRun : MonoBehaviour 
{
	public GameObject Player;

	void LateUpdate ()
	{
		transform.position = Player.transform.position + new Vector3 (0, 2, -10);
	}
}
