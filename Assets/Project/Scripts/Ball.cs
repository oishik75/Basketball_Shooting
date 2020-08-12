using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public GameObject particleTrail;
	// Use this for initialization
	void Start () {
		particleTrail.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ActivateTrail(){
		particleTrail.SetActive (true);
	}
}
