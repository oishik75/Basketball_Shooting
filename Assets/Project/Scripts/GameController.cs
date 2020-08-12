using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Player player;
	public float resetTimer = 5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (player.holdBall == false) {
			resetTimer -= Time.deltaTime;

			if(resetTimer<=0){
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
