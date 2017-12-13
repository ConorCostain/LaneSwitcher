using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 5f;
	public float transistionTime = 0.1f;


	private void FixedUpdate()
	{
		transform.position += Vector3.forward * 5f * Time.fixedDeltaTime;
	}
}
