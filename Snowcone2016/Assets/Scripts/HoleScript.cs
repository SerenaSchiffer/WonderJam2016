using UnityEngine;
using System.Collections;

public class HoleScript : MonoBehaviour {

	private bool isFilled;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (!isFilled) {
			if(other.gameObject.tag == "block")
				isFilled = true;
			Destroy (other.gameObject);
		}
	}
}
