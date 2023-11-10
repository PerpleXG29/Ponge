using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Menu : MonoBehaviour
{

    //Had Lapse in concentration when naming this script
    //This is the script to for the menu before starting AI level and 2 Player Level

    public GameObject menu;

    void Start()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
    }

   
    public void play()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
    }

    
}
