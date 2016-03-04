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

    Wires currentWire;

	// Use this for initialization
	void Start () {
        currentWire = Wires.noWire;
	}
	
	// Update is called once per frame
	void Update () {
	}

    void setCurrentWire(Wires newCurrentWire)
    {
        currentWire = newCurrentWire;
    }

    Wires getCurrentWire()
    {
        return currentWire;
    }
}
