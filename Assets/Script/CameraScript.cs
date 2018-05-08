using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	public GameObject unitychan;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.position = unitychan.transform.position + new Vector3 (0.5f, 1.7f, -2f);

	}
}
