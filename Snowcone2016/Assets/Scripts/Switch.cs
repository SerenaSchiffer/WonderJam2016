using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    public bool isInZone;
    public bool isActive;
	public bool isBridge = true;
    public Sprite switchOn;

	// Use this for initialization
	void Start () {
        isInZone = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isActive && isInZone && Input.GetKeyDown(KeyCode.Space))
        {
            if (isBridge)
            {
                gameObject.transform.GetChild(0).GetComponent<Bridge>().OpenBridge();
                gameObject.GetComponent<SpriteRenderer>().sprite = switchOn;
            }
            else
            {
                gameObject.transform.parent.GetChild(2).GetChild(0).GetComponent<Canon>().Fire();
            }
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
