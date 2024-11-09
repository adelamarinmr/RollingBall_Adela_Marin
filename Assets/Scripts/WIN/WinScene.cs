using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMainMenu",3); // llamar metodo y el 3 es a los seg que llama al metodo
    }

  public void LoadMainMenu()
  {
    SceneManager.LoadScene("MainMenu");
  }

}
