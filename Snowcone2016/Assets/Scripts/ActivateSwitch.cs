using UnityEngine;
using System.Collections;

public class ActivateSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.parent.GetChild(1).GetComponent<Switch>().ActivateSwitch();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
