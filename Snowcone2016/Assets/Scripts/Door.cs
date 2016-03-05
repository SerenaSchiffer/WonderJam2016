using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenDoor()
    {
        Destroy(gameObject.transform.GetChild(2).gameObject);
        Destroy(gameObject.transform.GetChild(3).gameObject);
    }
}
