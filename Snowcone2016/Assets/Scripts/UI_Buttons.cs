using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Buttons : MonoBehaviour {
	public void StartGame()
	{
		SceneManager.LoadScene (6);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}