using UnityEngine;
using System.Collections;

public class WireTrigger : MonoBehaviour {

    public bool isInZone;
    private Collider2D lastColliderEntered;

    // Use this for initialization
    void Start() {
        isInZone = false;
    }

    // Update is called once per frame
    void Update() {
        if (isInZone && lastColliderEntered != null)
        {
            if (lastColliderEntered.tag == "WireZone")
            {
                if (lastColliderEntered.GetComponent<WireStats>().isAWire && !gameObject.GetComponent<WireStats>().isAWire)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                    gameObject.GetComponent<WireStats>().setCurrentWire(lastColliderEntered.GetComponent<WireStats>().getCurrentWire());
                    }
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.GetComponent<WireStats>().setCurrentWire(Wires.noWire);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isInZone = true;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "WireZone")
        {
            lastColliderEntered = col;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        isInZone = false;
    }
}
