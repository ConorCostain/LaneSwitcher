using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 5f;
	public float transistionTime = 0.1f;
	

	private bool moveLeft = false;
	private bool moveRight = false;

	public void Update()
	{
		moveLeft = Input.GetKey("left");
		moveRight = Input.GetKey("right");
		
	}

	private void FixedUpdate()
	{
		transform.position += Vector3.forward * 5f * Time.fixedDeltaTime;

		if (moveLeft == moveRight)
		{
			Debug.Log("Center");
			Vector3 newPos = transform.position;
			newPos.x = 0;
			transform.position = Vector3.Lerp(transform.position, newPos, transistionTime);
		}
		else if (moveLeft)
		{
			Debug.Log("Left");
			Vector3 newPos = transform.position;
			newPos.x = -2;
			transform.position = Vector3.Lerp(transform.position, newPos, transistionTime);
		}
		else if (moveRight)
		{
			Debug.Log("Right");
			Vector3 newPos = transform.position;
			newPos.x = 2;
			transform.position = Vector3.Lerp(transform.position, newPos, transistionTime);
		}
		else
		{
			Debug.Log("Problem found bitch - playerMovement controller");
		}
	}
}
