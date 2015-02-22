using UnityEngine;
using System.Collections;

public class BorderTrigger : MonoBehaviour {

	void OnTriggerEnter(Collider coll) {
		coll.BroadcastMessage ("OnCollisionEnter2D", this.gameObject.collider2D);
	}
}
