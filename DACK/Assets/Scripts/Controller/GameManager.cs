using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	private const string HIGH_SCORE = "High Score";

	void Awake(){
		_MakeSingleInstance ();
		IsGameStartedForTheFirstTime ();
	}

	void IsGameStartedForTheFirstTime(){
		if (!PlayerPrefs.HasKey ("IsGameStartedForTheFirstTime")) {
			PlayerPrefs.SetInt (HIGH_SCORE, 0);
			PlayerPrefs.SetInt ("IsGameStartedForTheFirstTime", 0);
		}
	}

	void _MakeSingleInstance(){
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	public void SetHighScore(int score){
		PlayerPrefs.SetInt (HIGH_SCORE, score);
	}

	public int GetHighScore(){
		return PlayerPrefs.GetInt (HIGH_SCORE);
	}
}
