using UnityEngine;
using System.Collections;

public class StopSmoke : MonoBehaviour {

    bool isTheFirstChild;
	// Use this for initialization
	void Start () {
        //Stop smoke
        isTheFirstChild = false;
        foreach (Transform item in transform.parent)
        {
            if (isTheFirstChild)
            {
                if (item.transform.GetChild(0).GetComponent<ParticleSystem>() != null)
                {
                    Debug.Log(item.name);
                    item.transform.GetChild(0).GetComponent<ParticleSystem>().enableEmission = false;
                    Destroy(GameObject.FindGameObjectWithTag("fire"));
                }
            }
            else
            {
                isTheFirstChild = true;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
}
