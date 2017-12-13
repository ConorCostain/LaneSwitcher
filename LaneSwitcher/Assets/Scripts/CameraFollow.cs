using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Vector3 Offset = new Vector3();

	
	private GameObject player;
	
	// Use this for initialization
	private void Awake () {

		player = FindObjectsOfType<GameObject>().Where(g => g.tag == "Player").FirstOrDefault();

	}


	private void FixedUpdate()
	{
		transform.position = player.transform.position + Offset;
	}


}
