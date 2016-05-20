using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartSceneButton : MonoBehaviour {

	public void OnButtonClick() {
	
		SceneManager.LoadScene ("Main");

	}

}
