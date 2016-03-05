using UnityEngine;
using System.Collections;

public class WireTrigger : MonoBehaviour {

    public bool isInZone;
    private Collider2D lastColliderEntered;
    private Collider2D lastColliderEntered2;
    private Collider2D oldCollider;
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
            //aLineRenderer.SetPosition(0, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -5));
            //aLineRenderer.SetPosition(1, new Vector3(lastColliderEntered2.transform.position.x, lastColliderEntered2.transform.position.y, -5));
        }


        if (!isInZone)
        {
            
            DropWire();
        }

        if (lastColliderEntered != null)
        {
            /*if (lastColliderEntered.tag == "PlugZone")
            {
                Debug.Log(lastColliderEntered.tag + " " + gameObject.GetComponent<WireStats>().currentWire + " " + lastColliderEntered.GetComponent<WireStats>().currentWire);
            }*/
            /*if (lastColliderEntered.tag == "PlugZone" && gameObject.GetComponent<WireStats>().currentWire != lastColliderEntered.GetComponent<WireStats>().currentWire)
            {
                Debug.Log("GGGGGGGGGGGGGGGGGGG");
                gameObject.GetComponent<WireStats>().currentWire = Wires.noWire;
                lastColliderEntered2.GetComponent<WireStats>().setPickedUp(false);
                Destroy(aLineRenderer.gameObject);
            }*/


            Debug.Log("Je rentreeee");
            if (lastColliderEntered.tag == "WireZone")
            {
                if ((lastColliderEntered2 != null && lastColliderEntered != null) && lastColliderEntered != lastColliderEntered2 && aLineRenderer != null && aLineRenderer.gameObject != null)
                {
                    lastColliderEntered2.GetComponent<WireStats>().setPickedUp(false);
                    Destroy(aLineRenderer.gameObject);
                    aLineRenderer = null;
                }
                Debug.Log("Je Pick up");
                if (isInZone && Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("Bitches");
                    PickUpWire();
                }
            }
            else if (lastColliderEntered.tag == "PlugZone")
            {
                if (gameObject.GetComponent<WireStats>().currentWire == lastColliderEntered.gameObject.GetComponent<WireConnectionEvent>().typeOfConnection)
                {
                    PlugOnWire();
                    
                }
                else
                {
                    gameObject.GetComponent<WireStats>().currentWire = Wires.noWire;
                    lastColliderEntered2.GetComponent<WireStats>().setPickedUp(false);
                    Destroy(aLineRenderer.gameObject);
                }
           }
            lastColliderEntered2 = lastColliderEntered;
           
        }
        //lastColliderEntered = null;
    }

    void DropWire()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            if (gameObject.GetComponent<WireStats>().currentWire != Wires.noWire && aLineRenderer != null && aLineRenderer.gameObject != null)
            {
                Debug.Log("Je Drop le fil");
                gameObject.GetComponent<WireStats>().currentWire = Wires.noWire;
                lastColliderEntered2.gameObject.GetComponent<WireStats>().setPickedUp(false);
                Destroy(aLineRenderer.gameObject);
            }
        }
        
    }

    void PickUpWire()
    {
        if (lastColliderEntered.GetComponent<WireStats>().isAWire && !gameObject.GetComponent<WireStats>().isAWire)
        {
                Debug.Log(lastColliderEntered.GetComponent<WireStats>().currentWire + " " + lastColliderEntered2.GetComponent<WireStats>().currentWire);
                if (aLineRenderer != null && aLineRenderer.gameObject != null)
                {
                    lastColliderEntered2.GetComponent<WireStats>().setPickedUp(false);
                    Destroy(aLineRenderer.gameObject);
                }
                aWire = Instantiate(Resources.Load("Wire") as GameObject);
                aLineRenderer = aWire.GetComponent<LineRenderer>();
                aLineRenderer.SetWidth(0.001f, 0.001f);
                aLineRenderer.SetPosition(1, new Vector3(lastColliderEntered.transform.position.x, lastColliderEntered.transform.position.y,-5));
                lastColliderEntered.GetComponent<WireStats>().setPickedUp(true);
                gameObject.GetComponent<WireStats>().SetCurrentWire(lastColliderEntered.GetComponent<WireStats>().GetCurrentWire());
                ChangeTypeOfLine();
            }
    }

    void ChangeTypeOfLine()
    {
        string currentWire = gameObject.GetComponent<WireStats>().GetCurrentWire().ToString();
        Color currentColor = lastColliderEntered.GetComponent<WireStats>().GetDictionnary()[currentWire];
        aLineRenderer.SetColors(currentColor, currentColor);
        if (currentWire == "Black")
        {
            aLineRenderer.SetWidth(0.5f, 0.5f);
        }
        else
        {
            aLineRenderer.SetWidth(0.2f, 0.2f);
        }
        
    }

    void PlugOnWire()
    {

        if (lastColliderEntered.GetComponent<WireConnectionEvent>() as WireConnectionEvent != null && lastColliderEntered != null)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (gameObject.GetComponent<WireStats>().currentWire == lastColliderEntered.GetComponent<WireConnectionEvent>().typeOfConnection)
                {
                    lastColliderEntered.GetComponent<WireConnectionEvent>().SetConnected(true);
                    gameObject.GetComponent<WireStats>().currentWire = Wires.noWire;
                    aLineRenderer.SetPosition(0, lastColliderEntered.transform.position);
                    aLineRenderer = null;
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
