using UnityEngine;
using System.Collections;

public enum Wires
{
    noWire,
    Red,
    Blue,
    Yellow,
    Black,
    Violet
}


public class WireStats : MonoBehaviour {

    public bool isAWire;
    public bool hasBeenPickedUp;
    public Wires currentWire;

	// Use this for initialization
	void Start () {
        if (!isAWire)
        {
            currentWire = Wires.noWire;
        }
        else
        {
            hasBeenPickedUp = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void SetCurrentWire(Wires newCurrentWire)
    {
        if (!isAWire)
        {
            currentWire = newCurrentWire;
        }
    }

    public Wires GetCurrentWire()
    {
        return currentWire;
    }

    public void setPickedUp(bool isIt)
    {
        hasBeenPickedUp = isIt;
    }

    public bool GetIsPickedUp()
    {
        return hasBeenPickedUp;
    }
}
