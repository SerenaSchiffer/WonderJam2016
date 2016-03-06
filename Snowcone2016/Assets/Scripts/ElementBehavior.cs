using UnityEngine;
using System.Collections;

public class ElementBehavior : MonoBehaviour {

    public Wires WirePermitted;
    private GameObject character;
	// Use this for initialization
	void Start () {
        character = (GameObject)GameObject.FindGameObjectWithTag("character");
        Debug.Log(character.tag+ " "+ character.name);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "character")
        {if (character.GetComponent<WireStats>().currentWire != WirePermitted)
            {
                character.GetComponent<WireTrigger>().DropWire(true);
            }
        }
    }
}
