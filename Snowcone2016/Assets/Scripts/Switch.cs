using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

    public bool isInZone;
    public bool isActive;
	public bool isBridge = true;
    private bool isPull;
    public Sprite switchOn;
    public Sprite switchOff;
    private int cptSwitch;

	// Use this for initialization
	void Start () {
        isInZone = false;
        isPull = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(cptSwitch > 0)
        {
            cptSwitch--;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = switchOff;
            isPull = false;
                
        }
		if(isActive && isInZone && Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = switchOn;
            if (isBridge)
            {
                gameObject.transform.GetChild(0).GetComponent<Bridge>().OpenBridge();
                isPull = true;
                cptSwitch = 10;
            }
            else if(!isPull)
            {
                gameObject.transform.parent.GetChild(2).GetChild(0).GetComponent<Canon>().Fire();
                isPull = true;
                cptSwitch = 50;

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
