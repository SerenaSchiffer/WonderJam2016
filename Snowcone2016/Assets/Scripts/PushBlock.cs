using UnityEngine;
using System.Collections;

public class PushBlock : MonoBehaviour {

	public int pushDelay;

	// Use this for initialization
	void Start () {	
		pushDelay = 60;
	}

	void OnCollisionStay2D()
	{
		if (Input.GetAxisRaw ("Horizontal") != 0 || Input.GetAxisRaw ("Vertical") != 0)
		{
			pushDelay--;
			if (pushDelay == 0)
				MoveBlock ((int)Input.GetAxisRaw ("Horizontal"), (int)Input.GetAxisRaw ("Vertical"));
		} 
		else
			pushDelay = 60;
	}

	void OnCollisionExit2D()
	{
		pushDelay = 60;
	}

	void MoveBlock(int hor, int ver)
	{
		if (hor != 0) {
			if (hor == 1)
				gameObject.transform.position = new Vector2 (transform.position.x + 0.5f, transform.position.y + 0.25f);
			else
				gameObject.transform.position = new Vector2 (transform.position.x - 0.5f, transform.position.y - 0.25f);
		}
		else 
		{
			if (ver == 1) 
				gameObject.transform.position = new Vector2 (transform.position.x - 0.5f, transform.position.y + 0.25f);
			else
				gameObject.transform.position = new Vector2 (transform.position.x + 0.5f, transform.position.y - 0.25f);
		}
	}
}
