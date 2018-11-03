using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Update is called once per frame
	bool gameEnded = false;	
	public GameObject completeLevelUI;
	public float restartDelay = 2.5f;
	public void EndGame () {
		if(!gameEnded) {
			Debug.Log("Game Ended"); 
			gameEnded = true;
			Invoke("Restart", restartDelay);
		}
	}

	public void Restart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void CompleteLevel() {
		Debug.Log("Level Completed");
		completeLevelUI.SetActive(true);
	}
}
