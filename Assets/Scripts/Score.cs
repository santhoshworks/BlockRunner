using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Transform player;
	public Text score;
	void Update () {
		var text = player.position.z.ToString("0");
		score.text = text;
	}
}
