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
        if (character.gameObject.GetComponent<WireStats>().currentWire == WirePermitted &&  gameObject.GetComponent<Collider2D>().isTrigger == false)
        {
            gameObject.GetComponent<Collider2D>().isTrigger = true;
        }
        else if(gameObject.GetComponent<Collider2D>().isTrigger == true && character.GetComponent<WireStats>().currentWire != WirePermitted)
        {
            gameObject.GetComponent<Collider2D>().isTrigger = false;
        }
	}
}
