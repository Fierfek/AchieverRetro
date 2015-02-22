using UnityEngine;
using System.Collections;

public class Borders : MonoBehaviour {

	public GameObject[] borders;
	Vector3 worldPoint;
	public Ball ball;

	void Start () {
		//set position
		worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height/2, 1));
		borders[0].transform.position = worldPoint;
		worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height/2, 1));
		borders[1].transform.position = worldPoint;
		worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, 0, 1));
		borders[2].transform.position = worldPoint;
		worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height, 1));
		borders[3].transform.position = worldPoint;
	}

	void Update () {

	}
}