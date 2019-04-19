using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {

	public static GamePlayController instance;

	[SerializeField]
	private Button instructionButton;

	[SerializeField]
	private Text scoreText,endScoreText,bestScoreText;

	[SerializeField]
	private GameObject gameOverPanel, pausePanel;

	void Awake(){
		Time.timeScale = 0;
		_MakeInstance ();
	}

	void _MakeInstance(){
		if (instance == null) {
			instance = this;
		}
	}

	public void _InstructionButton(){
		Time.timeScale = 1;
		instructionButton.gameObject.SetActive (false);
	}

	public void _SetScore(int score){
		scoreText.text = "" + score;
	}

	public void _BirdDiedShowPanel(int score){
		gameOverPanel.SetActive (true);

		endScoreText.text = "" + score;
		if (score > GameManager.instance.GetHighScore ()) {
			GameManager.instance.SetHighScore (score);
		}
		bestScoreText.text = "" + GameManager.instance.GetHighScore();

	}

	public void _MenuButton(){
		Application.LoadLevel ("MainMenu");
	}

	public void _RestartGameButton(){
		Application.LoadLevel ("GamePlay");
		//Application.LoadLevel (Application.loadedLevel);
	}

	public void _PauseButton(){
		Time.timeScale = 0;
		pausePanel.SetActive (true);
	}

	public void _ResumeButton(){
		Time.timeScale = 1;
		pausePanel.SetActive (false);
	}
}
