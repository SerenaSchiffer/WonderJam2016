using UnityEngine;
using System.Collections;

public class CanonProjectile : MonoBehaviour {

	public GameObject target = null;

	private int ttl = 120;

	void FixedUpdate()
	{
		transform.Translate (new Vector2 (1f, 0.5f) * 0.05f);
		if (ttl-- == 0) {
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.GetInstanceID () == target.GetInstanceID ())
		{
			Destroy (target);
			Destroy (this.gameObject);
		}
	}
}
