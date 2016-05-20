using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	private int counter = 0;
	private int totalPickups = 0;

	public float speed;
	public Text counterText;
	public GameObject gameoverObject;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		GameObject[] pickups = GameObject.FindGameObjectsWithTag ("pickup");
		totalPickups = pickups.Length;
	}

	void FixedUpdate() {
		float vert_axis = Input.GetAxis ("Vertical");
		float hor_axis = Input.GetAxis ("Horizontal");

		Vector3 force = new Vector3 (hor_axis, 0, vert_axis) * speed;
		rb.AddForce (force, ForceMode.Force);
	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("pickup")) {
			other.gameObject.SetActive(false);
			counter++;
			UpdateCounterDisplay ();

			if (counter >= totalPickups) {
				gameoverObject.SetActive(true);
			}

		}
	}

	void UpdateCounterDisplay() {
	
		counterText.text = "" + counter + " coins";
	}
}
