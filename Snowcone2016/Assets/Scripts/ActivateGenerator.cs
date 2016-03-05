using UnityEngine;
using System.Collections;

public class ActivateGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.parent.GetChild(1).GetComponent<Generator>().ActivateGenerator();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
