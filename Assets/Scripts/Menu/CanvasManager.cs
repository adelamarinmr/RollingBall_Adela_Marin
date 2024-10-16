using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    public void EmpezarPartida()
    {
        SceneManager.LoadScene(1);
    }
    

    public void TerminarJuego()
    { //solo funciona con el ejecutable
        Application.Quit();
    }


















}
