using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour {

    public bool isActive;
    private Rigidbody2D metalBlock;
    private Transform magnetCenter;

	// Use this for initialization
	void Start () {
        isActive = false;
        metalBlock = gameObject.transform.GetChild(0).GetComponent<Rigidbody2D>();
        magnetCenter = gameObject.transform.GetChild(1);
	}
	
	// Update is called once per frame
	void Update () {
	    if(isActive)
        {
            Debug.Log(metalBlock.gameObject.name);
            //metalBlock.AddForce(new Vector3(-1 * 4 * Time.deltaTime, -0.5f * 4 * Time.deltaTime,-10));
            metalBlock.AddForce(new Vector3(-8 * Time.deltaTime, -4 * Time.deltaTime, 0));
            Vector3 force = magnetCenter.position - metalBlock.transform.position;
            metalBlock.AddForceAtPosition(force, gameObject.transform.position);
        }
	}

    public void ActivateMagnet()
    {
        isActive = true;
    }
}
