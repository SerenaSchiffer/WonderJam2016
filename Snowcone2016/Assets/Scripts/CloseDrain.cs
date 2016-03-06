using UnityEngine;
using System.Collections;

public class CloseDrain : MonoBehaviour {
    GameObject water;
    // Use this for initialization
    void Start () {
        //Close drain and destroy water
        water = GameObject.FindGameObjectWithTag("water");
    }
	
	// Update is called once per frame
	void Update () {
       if(water.transform.localScale.x > 0.2f && water.transform.localScale.y > 0.2f)
        {
            water.transform.localScale += new Vector3(-0.01f,-0.01f ,0);
        }else
        {
            Destroy(water);
        }
	}
}
