using UnityEngine;
using System.Collections;

public class CheckPointHandler : MonoBehaviour {

    Vector3 LastCheckPoint;
	// Use this for initialization
	void Start () {
        LastCheckPoint = new Vector3(15.24f, -0.5f);

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "checkPoint")
        {
            Debug.Log("Gotcha");
            LastCheckPoint = col.transform.position;
            GameObject.FindGameObjectWithTag("character").GetComponent<Animator>().SetBool("Dead", false);
            GameObject.FindGameObjectWithTag("character").GetComponent<WireTrigger>().DropWire();
            gameObject.GetComponent<BatteryLife>().RefillBattery();
        }
    }

    public Vector3 getLastCheckPoint()
    {
        return LastCheckPoint;
    }
}
