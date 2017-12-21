using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
	private float score = 0f;



	private void OnTriggerEnter(Collider trigger)
	{
		if(trigger.tag == "Obstacle")
		{
			Obstacle(trigger);
		}
		else if (trigger.tag == "Objective")
		{
			Objective(trigger);
		}
	}

	private void Obstacle(Collider trigger)
	{
		PlaySessionManager.ins.obstaclesHit++;
	}

	private void Objective(Collider trigger)
	{
		PlaySessionManager.ins.objectivesHit++;
	}
}
