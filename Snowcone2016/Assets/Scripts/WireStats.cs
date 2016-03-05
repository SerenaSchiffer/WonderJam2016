using UnityEngine;
using System.Collections;
using System.Collections.Generic;

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

    public Dictionary<string, Color> dicto;

    // Use this for initialization
    void Start () {
        dicto = new Dictionary<string, Color>();
        dicto.Add("noWire", Color.clear);
        dicto.Add("Red", Color.red);
        dicto.Add("Blue", Color.blue);
        dicto.Add("Yellow", Color.yellow);
        dicto.Add("Black", Color.black);
        dicto.Add("Violet", Color.magenta);

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

    public Dictionary<string, Color> GetDictionnary()
    {
        return dicto;
    }
}
