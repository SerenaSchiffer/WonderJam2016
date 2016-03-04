using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BatteryLife : MonoBehaviour {

	public GameObject batteryUI = null;
	public float timer = 60;


	private float maxTimer;
	private Slider mySlider;

	void Awake(){
		maxTimer = timer;
		mySlider = batteryUI.GetComponentInChildren<Slider> ();
	}

	// Update is called once per frame
	void Update () {
		if (timer > float.Epsilon) {
			timer -= Time.deltaTime;
			mySlider.value = timer / maxTimer;
		} else 
		{
			Debug.Log ("u die bitch");
		}
	}
}
