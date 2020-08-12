using UnityEngine;
using System.Collections;

public class ScoreArea : MonoBehaviour {

	public GameObject scoreParticle;
	// Use this for initialization
	void Start () {
		scoreParticle.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Ball") {
			scoreParticle.SetActive (true);
		}
	}
}
