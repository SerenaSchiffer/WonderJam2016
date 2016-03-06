using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BatteryLife : MonoBehaviour {

	public GameObject batteryUI = null;
	public float timer = 60;

    private bool isTriggered;


	private float maxTimer;
	private Slider mySlider;

	void Awake(){
		maxTimer = timer;
		mySlider = batteryUI.GetComponentInChildren<Slider> ();
        isTriggered = false;

    }

	// Update is called once per frame
	void Update () {
		if (timer > float.Epsilon) {
			timer -= Time.deltaTime;
			mySlider.value = timer / maxTimer;
                
		} else 
		{
            if (!isTriggered)
            {
                GameObject.FindGameObjectWithTag("character").GetComponent<Animator>().SetTrigger("Dying");
                isTriggered = true;
            }
            GameObject.FindGameObjectWithTag("character").GetComponent<Animator>().SetBool("Dead", true);
        }
	}

    public void RefillBattery()
    {
        timer = 60;
    }
}
