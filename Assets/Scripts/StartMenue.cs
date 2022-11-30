using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenue : MonoBehaviour
{



    private void Start()
    {
        Cursor.lockState = CursorLockMode.None; 
        Cursor.visible = true; 
    }

    public void PressPlay() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1); 
    }

    public void PressQuit() 
    {
        Application.Quit(); 
    }
}

