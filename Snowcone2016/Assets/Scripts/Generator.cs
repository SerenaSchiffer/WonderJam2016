using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public bool isActive;
	// Use this for initialization
	void Start () {
        isActive = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ActivateGenerator()
    {
        isActive = true;
		GetComponentInChildren<Animator> ().SetTrigger ("plug_head");
		GameObject.Find ("Bob 1").GetComponent<SpriteRenderer> ().enabled = false;
        gameObject.transform.GetChild(0).GetComponent<Door>().OpenDoor();
    }
}
