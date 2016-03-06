using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class FinalGenerator : MonoBehaviour {

    Generator generator;

	private int timeToLive;
	// Use this for initialization
	void Start () {
        generator = gameObject.GetComponent<Generator>();
		timeToLive = 0;
	}
	
	// Update is called once per frame
	void Update () {
	    if(generator.isActive)
        {
			timeToLive++;
			GameObject.Find ("KekLight").GetComponent<Light> ().intensity = (float)timeToLive / 100f;
			if (timeToLive == 800) {
				SceneManager.LoadScene (0);
			}
        }
	}
}
