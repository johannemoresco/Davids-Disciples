using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 public void loadGame()
    {
        SceneManager.LoadScene("Krishna");
    }
 public void loadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }   
}
