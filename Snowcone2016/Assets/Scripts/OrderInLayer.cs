using UnityEngine;
using System.Collections;

public class OrderInLayer : MonoBehaviour {

	private SpriteRenderer mySR;

	void Awake()
	{
		mySR = GetComponent<SpriteRenderer> ();
	}

	void LateUpdate()
	{
		mySR.sortingOrder = (int)(transform.position.y * -100);
	}
}
