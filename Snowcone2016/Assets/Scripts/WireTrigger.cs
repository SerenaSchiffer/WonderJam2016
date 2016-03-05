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
    void Update()
    {
        if (isInZone && lastColliderEntered != null)
        {
           
            if (lastColliderEntered.tag == "WireZone")
            {
                pickUpWire();
            }
            else if (lastColliderEntered.tag == "PlugZone")
            {
                PlugOnWire();
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    gameObject.GetComponent<WireStats>().SetCurrentWire(Wires.noWire);
                }
            }
        }
    }

    void pickUpWire()
    {
        if (lastColliderEntered.GetComponent<WireStats>().isAWire && !gameObject.GetComponent<WireStats>().isAWire)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.GetComponent<WireStats>().SetCurrentWire(lastColliderEntered.GetComponent<WireStats>().GetCurrentWire());
            }
        }
    }

    void PlugOnWire()
    {
        if (lastColliderEntered.GetComponent<WireConnectionEvent>() as WireConnectionEvent != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (gameObject.GetComponent<WireStats>().currentWire == lastColliderEntered.GetComponent<WireConnectionEvent>().typeOfConnection)
                {
                    lastColliderEntered.GetComponent<WireConnectionEvent>().SetConnected(true);
                    gameObject.GetComponent<WireStats>().currentWire = Wires.noWire;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        isInZone = true;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "WireZone" || col.tag == "PlugZone")
        {
            lastColliderEntered = col;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        isInZone = false;
    }
}
