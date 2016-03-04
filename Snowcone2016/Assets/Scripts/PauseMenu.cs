using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	
	public GameObject pauseMenu = null; 
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(!(pauseMenu.active));
            Time.timeScale = (Time.timeScale + 1 ) % 2;
        }
    }
}
