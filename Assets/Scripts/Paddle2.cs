using UnityEngine;
using System.Collections;

public class Paddle2 : MonoBehaviour {
	Vector3 worldPoint;
	public Paddle1 paddle1; 
	// Use this for initialization
	void Start () {
		worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, (float)(Screen.height * .87), 1));
		transform.position = worldPoint;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (-paddle1.transform.position.x, transform.position.y, 0);
	}
}