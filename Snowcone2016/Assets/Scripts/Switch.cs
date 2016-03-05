using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    public bool isInZone;
    public bool isActive;
	// Use this for initialization
	void Start () {
        isInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
	    
        if(isActive && isInZone && Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.GetChild(0).GetComponent<Bridge>().OpenBridge();
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "character")
        {
            isInZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "character")
        {
            isInZone = false;
        }
    }

    public void ActivateSwitch()
    {
        isActive = true;
    }
}
