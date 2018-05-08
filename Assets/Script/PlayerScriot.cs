using UnityEngine;
using System.Collections;

public class PlayerScriot : MonoBehaviour {

	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("up")) {
			transform.position += transform.forward * 0.05f;
			animator.SetBool("is_running", true);
		} else {
			animator.SetBool("is_running", false);
		}
		if (Input.GetKey("right")) {
			transform.Rotate(0, 10, 0);
		}
		if (Input.GetKey ("left")) {
			transform.Rotate(0, -10, 0);
		}
		void onTriggerEnter(Collider other){
			GetComponent<Rigidbody>().velocity = new Vector3(0.0f,0.0f,0.0f);
		}
	
	}
}