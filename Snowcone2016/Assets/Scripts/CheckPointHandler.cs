using UnityEngine;
using System.Collections;

public class CheckPointHandler : MonoBehaviour {

    Vector3 LastCheckPoint;
	// Use this for initialization
	void Start () {
	
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
        }
    }

    public Vector3 getLastCheckPoint()
    {
        return LastCheckPoint;
    }
}
