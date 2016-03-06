using UnityEngine;
using System.Collections;

public class SortingLayerBob : MonoBehaviour {

    private SpriteRenderer boule;
    private SpriteRenderer chest;
    private SpriteRenderer armLeft;
    private SpriteRenderer handLeft;
    private SpriteRenderer shoulderLeft;
    private SpriteRenderer armRight;
    private SpriteRenderer handRight;
    private SpriteRenderer shoulderRight;
    private SpriteRenderer neck;
    private SpriteRenderer head;
    int sortingLayer = 0;

    void Start()
    {
        boule = GameObject.Find("Boule").GetComponent<SpriteRenderer>();
        chest = GameObject.Find("Chest").GetComponent<SpriteRenderer>();
        armLeft = GameObject.Find("ArmLeft").GetComponent<SpriteRenderer>();
        handLeft = GameObject.Find("HandLeft").GetComponent<SpriteRenderer>();
        shoulderLeft = GameObject.Find("ShoulderLeft").GetComponent<SpriteRenderer>();
        shoulderRight = GameObject.Find("ShoulderRight").GetComponent<SpriteRenderer>();
        armRight = GameObject.Find("ArmRight").GetComponent<SpriteRenderer>();
        handRight = GameObject.Find("HandRight").GetComponent<SpriteRenderer>();
        shoulderRight = GameObject.Find("ShoulderRight").GetComponent<SpriteRenderer>();
        neck = GameObject.Find("Neck").GetComponent<SpriteRenderer>();
        head = GameObject.Find("Head").GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        sortingLayer = (int)(transform.position.y * -100);
        boule.sortingOrder = sortingLayer;
        Debug.Log(chest.sortingOrder);
        Debug.Log(sortingLayer);
        chest.sortingOrder = (sortingLayer + 3);
        armLeft.sortingOrder = sortingLayer + 2;
        handLeft.sortingOrder = sortingLayer + 1;
        shoulderLeft.sortingOrder = sortingLayer + 4;
        armRight.sortingOrder = sortingLayer + 7;
        handRight.sortingOrder = sortingLayer + 6;
        shoulderRight.sortingOrder = sortingLayer + 8;
        neck.sortingOrder =  sortingLayer + 5;
        head.sortingOrder = sortingLayer + 6;

        Debug.Log("I'm fast enough");
    }
}
