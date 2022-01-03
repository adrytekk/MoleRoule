using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{

    public GameObject Menu;
    public GameObject WorldsSelection;

    private void Start()
    {
        Menu.SetActive(true);
        WorldsSelection.SetActive(false);
    }

    public void WorldSelect()
    {
        Menu.SetActive(false);
        WorldsSelection.SetActive(true);
    }
    
    public void Play()
    {
        SceneManager.LoadScene("Lvl1");
    }

    public void Quit()
    {
        Application.Quit();
    } 

}
