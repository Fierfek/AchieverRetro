using UnityEngine;
using System.Collections;

public class Paddle1 : MonoBehaviour {
	Vector3 worldPoint;
	// Use this for initialization
	void Start () {
		worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, (float)(Screen.height * .13), 1));
		transform.position = worldPoint;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			worldPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			transform.position = new Vector3(worldPoint.x, transform.position.y, 0);
		}
	}
}
