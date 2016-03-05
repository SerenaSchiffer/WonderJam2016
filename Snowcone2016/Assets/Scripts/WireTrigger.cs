using UnityEngine;
using System.Collections;

public class WireTrigger : MonoBehaviour {

    public bool isInZone;
    private Collider2D lastColliderEntered;
    private Collider2D lastColliderEntered2;
    private GameObject aWire;
    private LineRenderer aLineRenderer;

    // Use this for initialization
    void Start() {
        isInZone = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(aLineRenderer != null)
        {
            aLineRenderer.SetPosition(0, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,-5));
        }


        if (!isInZone)
        {
            
            DropWire();
        }

        if (lastColliderEntered != null)
        {
            lastColliderEntered2 = lastColliderEntered;
            Debug.Log("Je rentreeee");
            if (lastColliderEntered.tag == "WireZone")
            {
                Debug.Log("Je Pick up");
                PickUpWire();
            }
            else if (lastColliderEntered.tag == "PlugZone")
            {
                Debug.Log("Je PLug");
                PlugOnWire();
            }
        }
        lastColliderEntered = null;
    }

    void DropWire()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Je Drop le fil");
            gameObject.GetComponent<WireStats>().currentWire = Wires.noWire;
            lastColliderEntered2.GetComponent<WireStats>().setPickedUp(false);
        }
        
    }

    void PickUpWire()
    {
        if (lastColliderEntered.GetComponent<WireStats>().isAWire && !gameObject.GetComponent<WireStats>().isAWire && lastColliderEntered.GetComponent<WireStats>().hasBeenPickedUp == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                aWire = Instantiate(Resources.Load("Wire") as GameObject);
                aLineRenderer = aWire.GetComponent<LineRenderer>();
                aLineRenderer.SetPosition(1, new Vector3(lastColliderEntered.transform.position.x, lastColliderEntered.transform.position.y,-5));
                ChangeTypeOfLine();
                lastColliderEntered.GetComponent<WireStats>().setPickedUp(true);
                gameObject.GetComponent<WireStats>().SetCurrentWire(lastColliderEntered.GetComponent<WireStats>().GetCurrentWire());
            }
        }
    }

    void ChangeTypeOfLine()
    {
        Debug.Log("kek");
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
