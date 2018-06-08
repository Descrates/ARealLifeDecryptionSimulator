using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    int excaped = -1;

    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void GuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            excaped =+ 1;
        }
        if(excaped == 2)
        {
            excaped = 0;
        }
        if(excaped == 0)
        {
            SceneManager.LoadScene(1);
            excaped = -1;
        }
        if (excaped == 1)
        {
            SceneManager.LoadScene(2);
        }
        
    }
}
