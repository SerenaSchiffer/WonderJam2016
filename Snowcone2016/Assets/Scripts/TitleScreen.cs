using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour {
	public Image mask;
	private float maskOpacity;
	private bool up;


	void Start(){
		maskOpacity = 0f;
		up = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (up) {
			if (maskOpacity < 0.2f) {
				maskOpacity += 0.001f;
			} else {
				up = false;
			}
		} else {
			if (maskOpacity > float.Epsilon) {
				maskOpacity -= 0.001f;
			} else {
				up = true;
			}
		}
		mask.color = new Color (mask.color.r, mask.color.g, mask.color.b, maskOpacity);
	}
}
