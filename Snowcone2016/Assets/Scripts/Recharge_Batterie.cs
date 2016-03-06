using UnityEngine;
using System.Collections;

public class Recharge_Batterie : MonoBehaviour {

	void OnTriggerStay2D(Collider2D other)
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (other.gameObject.tag == "character") 
			{
				GetComponentInChildren<Animator> ().SetTrigger ("plug_head");
				GameObject.Find ("EventSystem").GetComponent<BatteryLife> ().RefillBattery ();
				//GameObject.Find ("Bob 1").GetComponent<SpriteRenderer> ().enabled = false;
                foreach (SpriteRenderer sprite in GameObject.Find("Bob 1").GetComponentsInChildren<SpriteRenderer>())
                {
                    sprite.enabled = false;
                }
            }
        }
	}
}
