﻿using UnityEngine;
using System.Collections;

public class GeneratorAnimationHelper : MonoBehaviour {

	public void PlsHelp()
	{
		GameObject.Find ("Bob 1").GetComponent<SpriteRenderer> ().enabled = true;
	}

	public void PlsHelp2()
	{
		gameObject.GetComponent<AudioSource> ().Play ();
	}
}
