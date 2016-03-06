using UnityEngine;
using System.Collections;

public class WireConnectionEvent : MonoBehaviour {

    public bool isWall;
    public bool connected;
    public Wires typeOfConnection;

	// Use this for initialization
	void Start () {
        connected = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetConnected(bool isIt)
    {
        
        connected = isIt;
        if(connected)
        {
            if (!isWall)
            {
                GameObject.Find("Bob 1").GetComponent<Animator>().SetTrigger("Plug");
            }
            else
            {
                GameObject.Find("Bob 1").GetComponent<Animator>().SetTrigger("PlugMur");
            }
            Debug.Log(GameObject.FindGameObjectWithTag("character").GetComponent<Animator>().gameObject.name);
            ActivateChildObjects();
        }
    }

    public bool GetConnected()
    {
        return connected;
    }

    public Wires GetTypeOfConnection()
    {
        return typeOfConnection;
    }

    private void ActivateChildObjects()
    {
        gameObject.SetActiveRecursively(true);
    }
}
