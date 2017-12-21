using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySessionManager : MonoBehaviour {
	public static PlaySessionManager ins;
	public float score = 0f;
	public int obstaclesHit = 0;
	public int objectivesHit = 0;
	public float distanceTravelled = 0f;

	private void Awake()
	{
		if(ins == null)
		{
			ins = this;
		}
		else if (ins != this)
		{
			Destroy(gameObject);
			return;
		}
	}

	private void Update()
	{
		updateScore();
	}

	private void FixedUpdate()
	{
		distanceTravelled = FindObjectOfType<PlayerMovement>().transform.position.z;
	}

	private void updateScore()
	{
		score = (distanceTravelled * 10) + (objectivesHit * 100) - (obstaclesHit * 50);
		Debug.Log(((int)score).ToString());
	}

	

}
