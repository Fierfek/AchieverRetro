using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball : MonoBehaviour {
	public float speed = 10;
	public Vector3 move;
	public Text score1, score2;
	int scoreInt1 = 0, scoreInt2 = 0;
	public AudioSource sound;
	public AudioClip wall, score, paddle;
	double colPrevTime = 0, colDif = .2;
	bool trigger;

	void Start () {
		move = rigidbody2D.velocity = Random.onUnitSphere;
	}

	void Update () {
		transform.Translate(move * speed * Time.deltaTime); 
	}

	void OnCollisionEnter2D(Collision2D coll)
	{

		if (Time.time - colPrevTime < colDif) {
			move.y += .1f;
		}

		sound.clip = null;
		if (coll.gameObject.name == "Top") {
			scoreInt2 += 1;
			score2.text = scoreInt2.ToString();
			sound.clip = score;
			reset();
		}
		if (coll.gameObject.name == "Bottom") {
			scoreInt1 += 1;
			score1.text = scoreInt1.ToString();
			sound.clip = score;
			reset();
		}

		switch (coll.gameObject.name) {
		case "Left": move.x *= -1; sound.clip = wall; break;
		case "Right": move.x *= -1; sound.clip = wall; break;
		case "Paddle": move.y *= -1; move.x -= (coll.gameObject.transform.position.x - transform.position.x); sound.clip = paddle; break;
		}

		if(sound.clip != null)
			sound.Play();
		colPrevTime = Time.time;
	}

	void reset() {
		transform.position = new Vector3 (0, 0, 0);
		//while (move.x > move.y) {
			move = rigidbody2D.velocity = Random.onUnitSphere;
		//}

	}
}
