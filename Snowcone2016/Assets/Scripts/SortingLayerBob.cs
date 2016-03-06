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
        
        int sortingLayer = (int)(transform.position.y * -100);
        Debug.Log(boule.sortingOrder);
        boule.sortingOrder = sortingLayer;
        chest.sortingOrder = sortingLayer - 3;
        armLeft.sortingOrder = 2 + sortingLayer - 4;
        handLeft.sortingOrder = 1 + sortingLayer - 2;
        shoulderLeft.sortingOrder = 4 + sortingLayer - 8;
        armRight.sortingOrder = 7 + sortingLayer - 14;
        handRight.sortingOrder = 7 + sortingLayer - 14;
        shoulderRight.sortingOrder = 8 + sortingLayer - 16;
        neck.sortingOrder = 5 + sortingLayer - 10;
        head.sortingOrder = 6 + sortingLayer - 12;
    }
}
