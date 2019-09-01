using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MiddleMenu : MonoBehaviour
{
    public static int goal = 0;

    public void Three()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        goal = 3;
    }

    public void Six()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        goal = 6;
    }

    public void Nine()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        goal = 9;
    }
}
