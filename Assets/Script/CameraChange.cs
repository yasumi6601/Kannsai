using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour {

	private GameObject MainCamera;
	private GameObject SubCamera;

	void Start () {
		MainCamera = GameObject.Find("MainCamera");
		SubCamera = GameObject.Find("SubCamera");

		SubCamera.SetActive(false);
	}

	void Update () {
		if(Input.GetKeyDown("space")){
			if(MainCamera.activeSelf){
				MainCamera.SetActive (false);
				SubCamera.SetActive (true);
			}else{
				MainCamera.SetActive (true);
				SubCamera.SetActive (false);
			}
		}
	}

}
