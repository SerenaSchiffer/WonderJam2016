using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Buttons2 : MonoBehaviour {
    public GameObject page1 = null;
    public GameObject page2 = null;
    
    public void KekHelp()
    {
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