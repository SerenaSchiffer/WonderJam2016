using UnityEngine;
using System.Collections;

public class CloseDrain : MonoBehaviour {
    GameObject water;
    SpriteRenderer sr;
    float transp;
    // Use this for initialization
    void Start () {
        //Close drain and destroy water
        water = GameObject.FindGameObjectWithTag("water");
        sr = water.GetComponent<SpriteRenderer>();
        transp = 1f;
    }
	
	// Update is called once per frame
	void Update () {
       if(water.transform.localScale.x > 0.2f && water.transform.localScale.y > 0.2f)
        {
            transp -= 0.005f;
            sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, transp);
        }
	}
}
