using UnityEngine;
using System.Collections;

public class SlingShoot : MonoBehaviour {
	public GameObject launchPoint;

	void Awake(){
		Transform launchPointTrans = transform.Find ("LaunchPoint");
		launchPoint = launchPointTrans.gameObject;
		launchPoint.SetActive (false);
	}

	void OnMouseEnter(){
		//print ("Mouse has entered, Sir!");
		launchPoint.SetActive (true);
	}

	void OnMouseExit(){
		//print ("Mouse has exited, Sir!");
		launchPoint.SetActive (false);
	}
}
