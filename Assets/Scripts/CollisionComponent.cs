﻿using UnityEngine;

public class CollisionComponent : MonoBehaviour {
	public PlayerMovement movement;
	void OnCollisionEnter(Collision collision) {
			
		Debug.Log(collision.collider.tag);
		if(collision.collider.tag == "obstacle") {
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
