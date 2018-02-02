using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	private float _score = 0;

	private string _scoreText;

	public void ScoreUpdate(){
		_score++;
        print(_score);
		_scoreText = string.Format("{0:00}", _score);
	}
}
