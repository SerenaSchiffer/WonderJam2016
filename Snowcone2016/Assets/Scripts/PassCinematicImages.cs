using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PassCinematicImages : MonoBehaviour {

    int cpt = 0;
    Transform[] lesImages;
    public GameObject imagesContainer;

	// Use this for initialization
	void Start () {
        if (imagesContainer != null)
        {
            lesImages = imagesContainer.GetComponentsInChildren<Transform>();
        }
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (imagesContainer != null)
        {
            switch (cpt)
            {
                case 200:
                    Destroy(lesImages[1].gameObject);
                    break;

                case 300:
                    Destroy(lesImages[2].gameObject);
                    break;

                case 325:
                    Destroy(lesImages[3].gameObject);
                    break;

                case 350:
                    Destroy(lesImages[4].gameObject);
                    break;

                case 375:
                    Destroy(lesImages[5].gameObject);
                    break;

                case 400:
                    Destroy(lesImages[6].gameObject);
                    break;

                case 425:
                    Destroy(lesImages[7].gameObject);
                    break;

                case 450:
                    Destroy(lesImages[8].gameObject);
                    break;

                case 600:
                    Destroy(lesImages[9].gameObject);
                    break;

                case 750:
                    SceneManager.LoadScene("rafaelSalle1");
                    break;
            }
        
        cpt++;
        }

        if (Input.anyKey)
        {
            Debug.Log("kek");
        }
	}
}
