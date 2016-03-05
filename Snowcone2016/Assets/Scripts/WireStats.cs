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
    public Wires currentWire;

	// Use this for initialization
	void Start () {
        if (!isAWire)
        {
            currentWire = Wires.noWire;
        }
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void setCurrentWire(Wires newCurrentWire)
    {
        if (!isAWire)
        {
            currentWire = newCurrentWire;
        }
    }

    public Wires getCurrentWire()
    {
        return currentWire;
    }
}
