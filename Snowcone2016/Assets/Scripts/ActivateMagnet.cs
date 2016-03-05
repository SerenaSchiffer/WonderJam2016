using UnityEngine;
using System.Collections;

public class ActivateMagnet : MonoBehaviour {

    Magnet magnet;
	// Use this for initialization
	void Start () {
        magnet = gameObject.transform.GetComponentInParent<Magnet>();
        magnet.ActivateMagnet();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
