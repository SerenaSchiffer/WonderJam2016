using UnityEngine;
using System.Collections;

public class HoleScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (other.gameObject);
	}

	void OnTriggerStay2D(Collider2D other)
	{
		Destroy (other.gameObject);
	}
}
