using UnityEngine;
using System.Collections;

public class GeneratorAnimationHelper : MonoBehaviour {

	public void PlsHelp()
	{
        foreach (SpriteRenderer sprite in GameObject.Find("Bob 1").GetComponentsInChildren<SpriteRenderer>())
        {
            sprite.enabled = true;
        }
        GameObject.Find ("Bob 1").GetComponent<SpriteRenderer> ().enabled = false;
	}

	public void PlsHelp2()
	{
		gameObject.GetComponent<AudioSource> ().Play ();
	}
}
