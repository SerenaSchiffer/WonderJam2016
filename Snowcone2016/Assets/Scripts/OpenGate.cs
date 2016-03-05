using UnityEngine;
using System.Collections;

public class OpenGate : MonoBehaviour {

    GameObject[] tableTile;
    bool puzzleCompleted;
    // Use this for initialization
    void Start () {
        tableTile = GameObject.FindGameObjectsWithTag("ActivableTile");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void VerifyPuzzle()
    {
        puzzleCompleted = true;
        foreach(GameObject tile in tableTile)
        {
            if(!tile.GetComponent<ActivateTile>().isActivate)
            {
                puzzleCompleted = false;
                break;
            }
        }

        if(puzzleCompleted)
        {
            //ADD OPEN GATE
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
