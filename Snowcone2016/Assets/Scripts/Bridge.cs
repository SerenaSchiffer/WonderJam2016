using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour {
    public bool isOpen; 

	// Use this for initialization
	void Start () {
        isOpen = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenBridge()
    {
        //SET ANIMATOR BRIDGE CORRECTLY

        isOpen = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;


    }
}
