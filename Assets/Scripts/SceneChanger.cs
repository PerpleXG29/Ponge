using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void One_Player()
    {
        SceneManager.LoadScene("AI_Level");
    }

    public void Two_Player()
    {
        SceneManager.LoadScene("Human_Level");
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
