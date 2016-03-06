using UnityEngine;
using System.Collections;

public class Canon : MonoBehaviour {

	public GameObject proj = null;
	public GameObject vase = null;


	Vector2 left;
	Vector2 right;
	Vector2 target;

	// Use this for initialization
	void Start () {
		left = transform.parent.GetChild (1).position;
		right = transform.parent.GetChild (2).position;
		target = right;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "LeftSide")
			target = right;
		else if (other.gameObject.name == "RightSide")
			target = left;
	}
		
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = Vector2.MoveTowards (transform.position, target, 0.05f);
	}


	public void Fire()
	{
        Debug.Log("PLAY THE SOUND");
        gameObject.GetComponent<AudioSource>().Play();
        GameObject projec = Instantiate (proj, new Vector2(transform.position.x + 0.5f, transform.position.y + 0.25f), Quaternion.identity) as GameObject;
		projec.GetComponent<CanonProjectile> ().target = vase;
	}
}
