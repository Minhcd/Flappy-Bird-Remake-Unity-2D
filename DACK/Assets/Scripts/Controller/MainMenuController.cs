using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public void _PlayButton(){
		Application.LoadLevel ("GamePlay");
		//SceneManager.LoadScene ("GamePlay");
	}
}
