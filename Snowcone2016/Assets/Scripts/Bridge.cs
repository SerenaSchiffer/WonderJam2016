using UnityEngine;
using System.Collections;

public class Bridge : MonoBehaviour {
    public bool isOpen;
    public Sprite bridge;

	// Use this for initialization
	void Start () {
        isOpen = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenBridge()
    {
        Destroy(gameObject);


    }
}
