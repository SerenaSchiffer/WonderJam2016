using UnityEngine;
using System.Collections;

public class OpenGate : MonoBehaviour {

    GameObject[] tableTile;
    bool puzzleCompleted;
    public Sprite OpenDoorDroite;
    public Sprite OpenDoorFondDroite;
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
            gameObject.transform.GetChild(0).GetChild(0).GetComponent<SpriteRenderer>().sprite = OpenDoorDroite;
            gameObject.transform.GetChild(0).GetChild(1).GetComponent<SpriteRenderer>().sprite = OpenDoorFondDroite;
            Destroy(gameObject.transform.GetChild(0).GetChild(2).gameObject);
        }
    }
}
