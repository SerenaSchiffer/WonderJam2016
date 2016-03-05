using UnityEngine;
using System.Collections;

public class ElementBehavior : MonoBehaviour {

    public Wires WirePermitted;
    private GameObject character;
	// Use this for initialization
	void Start () {
        character = (GameObject)GameObject.FindGameObjectWithTag("character");
	}
	
	// Update is called once per frame
	void Update () {
	if(character.GetComponent<WireStats>().currentWire == WirePermitted && gameObject.GetComponent<PolygonCollider2D>().isTrigger == false)
        {

        }
        else if(gameObject.GetComponent<PolygonCollider2D>().isTrigger == true)
        {

        }
	}
}
