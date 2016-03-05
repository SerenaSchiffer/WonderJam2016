using UnityEngine;
using System.Collections;

public class StopAtMagnet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "magnet")
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3();
        }
    }
}
