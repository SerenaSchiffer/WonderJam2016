using UnityEngine;
using System.Collections;

public class WireConnectionEvent : MonoBehaviour {

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
