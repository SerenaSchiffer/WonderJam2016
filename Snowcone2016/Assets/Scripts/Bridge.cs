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
        //SET ANIMATOR BRIDGE CORRECTLY
        gameObject.GetComponent<SpriteRenderer>().sprite = bridge;
        Destroy(gameObject.GetComponent<HoleScript>());
        gameObject.GetComponent<SpriteRenderer>().sortingLayerName = "Default";


    }
}
