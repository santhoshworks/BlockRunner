using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;
	public float forwardForce = 300f;
	public float sidewayForce = 50f;
	void FixedUpdate () {
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);
		if(Input.GetKey("a")) {
			rb.AddForce(-sidewayForce *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if(Input.GetKey("d")) {
			rb.AddForce(sidewayForce  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}
		if(rb.position.y < -1) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
