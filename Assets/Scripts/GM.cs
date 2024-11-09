using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour
{
    public TMP_Text coleccionNumbersText; //variables text
    private int coleccionablesNumber;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddColeccionable()
    {
        coleccionablesNumber++; // igual que coleccionablesNumber=coleccionablesNumber +1;

        coleccionNumbersText.text=coleccionablesNumber.ToString(); // to string convierte a txt

    }


}
