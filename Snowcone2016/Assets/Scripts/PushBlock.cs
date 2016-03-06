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
        GameObject.Find("Bob 1").GetComponent<Animator>().SetBool("Push", true);
        Debug.Log("PUSH");
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
        GameObject.FindGameObjectWithTag("character").GetComponent<Animator>().SetBool("Push", false);
        pushDelay = 60;
	}

	void MoveBlock(int hor, int ver)
	{
		
		if (ver != 0) {
			if (ver == 1)
				transform.Translate(new Vector2 (0.757f, 0.356f));
			else
				transform.Translate(new Vector2 (-0.757f, -0.356f));
		}
		else 
		{
			if (hor == 1)
				transform.Translate (new Vector2 (0.757f, -0.356f));
			else
				transform.Translate (new Vector2 (-0.757f, 0.356f));
		}
	}
}
