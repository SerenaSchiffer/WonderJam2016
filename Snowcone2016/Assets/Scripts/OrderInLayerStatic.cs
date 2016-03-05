using UnityEngine;
using System.Collections;

public class OrderInLayerStatic : MonoBehaviour {

	private SpriteRenderer mySR;

	void Start()
	{
        
        object[] obj = GameObject.FindSceneObjectsOfType(typeof(GameObject));
        foreach (object o in obj)
        {
            GameObject g = (GameObject)o;
            if(g.GetComponent<SpriteRenderer>())
                g.GetComponent<SpriteRenderer>().sortingOrder = (int)(g.transform.position.y * -100);
        }

        Destroy(this);
    }
}
