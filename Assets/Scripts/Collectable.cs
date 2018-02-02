using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	private ScoreCounter _count;

	void start(){
		_count = GetComponent<ScoreCounter>();
	}

	void OnTriggerEnter(Collider other) {
		
	if (other.gameObject.CompareTag ("Player")){
		
		this.gameObject.SetActive (false);
			GameObject.Find("Score").GetComponent<ScoreCounter>().ScoreUpdate();
            Destroy(gameObject);
		}
	}
}