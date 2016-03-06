using UnityEngine;
using System.Collections;

public class FinalGenerator : MonoBehaviour {

    Generator generator;
	// Use this for initialization
	void Start () {
        generator = gameObject.GetComponent<Generator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(generator.isActive)
        {
            Debug.Log("Ending phase");
        }
	}
}
