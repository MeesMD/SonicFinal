using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	private float rSpeed = 1.3f;

	private float _spin;

	public void Awake(){
		_spin = Random.Range (0, 360);
	}

	public void Update(){
		if(this.gameObject.CompareTag("Cube")){
			rotateCube ();
		}else if(this.gameObject.CompareTag("Sun")){
			rotateCoin ();
		}else if (this.gameObject.CompareTag("Trap")){
			rotateSpike ();
		}
	}

	public void rotateCube(){
		transform.rotation = Quaternion.Euler(_spin+=rSpeed, _spin+=rSpeed, _spin+=rSpeed);	
	}

	public void rotateCoin(){
		transform.rotation = Quaternion.Euler(90, _spin+=rSpeed, 90);	
	}

	public void rotateSpike(){
		transform.rotation = Quaternion.Euler(0, 0, _spin+=rSpeed);	
	}
}
