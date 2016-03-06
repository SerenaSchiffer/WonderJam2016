using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Buttons : MonoBehaviour {
    public GameObject page1 = null;
    public GameObject page2 = null;
	public void StartGame()
	{
		SceneManager.LoadScene (6);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

    public void KekHelp()
    {
        if(page1 && page2)
        page1.active = true;
        page2.active = false;
    }

    public void KekNext()
    {
        page1.active = false;
        page2.active = true;
    }

    public void KekPrev()
    {
        page1.active = true;
        page2.active = false;
    }

    public void KekExit()
    {
        page1.active = false;
        page2.active = false;
    }
}