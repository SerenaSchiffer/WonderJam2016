using UnityEngine;
using System.Collections;

public class ActivateTile : MonoBehaviour {

    public bool isActivate;
    private SpriteRenderer tileSprite;
    OpenGate gateToOpen;
	// Use this for initialization
	void Start () {
        gateToOpen = gameObject.transform.GetComponentInParent<OpenGate>();
        isActivate = false;
        tileSprite = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "character")
        {
            Debug.Log("Enter");
            isActivate = !isActivate;
            if(isActivate)
            {
                tileSprite.color = Color.red;
				GetComponentInChildren<Light> ().color = Color.red;
                gateToOpen.VerifyPuzzle();
            }
            else
            {
                tileSprite.color = Color.blue;
				GetComponentInChildren<Light> ().color = Color.blue;
            }

        }
    }
}
