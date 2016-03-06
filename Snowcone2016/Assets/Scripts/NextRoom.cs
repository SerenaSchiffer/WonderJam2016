using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextRoom : MonoBehaviour {
	public static int roomNumber = 1;

	void OnTriggerEnter2D(Collider2D kek)
	{
		if (kek.gameObject.tag == "character") {
			SceneManager.LoadScene (++roomNumber);
		}
	}
}
