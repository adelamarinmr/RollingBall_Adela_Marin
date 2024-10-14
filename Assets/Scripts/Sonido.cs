using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{

    [SerializeField] AudioSource sfx;
    // Start is called before the first frame update
    
   

   public void ReproducirSonido(AudioClip magicSound)
    {
        sfx.PlayOneShot(magicSound); //Ejecuta el clip introducido x parámetro
    }







}



