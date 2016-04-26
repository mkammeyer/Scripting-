using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour 
{
		public float scrollSpeed = 1.0f; // how fast the backgrounds will move
		public float tileSizeZ = 10.0f; // how long the scroll of the title will go
		
		private Vector3 startPosition;
		
		void Start ()
		{
			startPosition = transform.position;
		}
		
		void Update ()
		{
			float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ); // when it reaches the end of the tileSizeZ it will start over
			transform.position = startPosition + Vector3.left * newPosition;
		}
}
