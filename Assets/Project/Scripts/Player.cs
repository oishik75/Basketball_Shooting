using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject ball;
	public GameObject playerCamera;
	public float ballDistance = 2f;
	public float ballThrowingForce;

	public bool holdBall = true;
	// Use this for initialization
	void Start () {
		ball.GetComponent<Rigidbody> ().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (holdBall) {
			ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
			if(Input.GetMouseButtonDown(0)){
				holdBall = false;
				ball.GetComponent<Ball>().ActivateTrail();
				ball.GetComponent<Rigidbody> ().useGravity = true;
				ball.GetComponent<Rigidbody> ().AddForce(playerCamera.transform.forward * ballThrowingForce);
			}
		}
	}
}
