using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text collectiblesNumbersText; //variables text
    private int collectiblesNumber;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCollectible()
    {
        collectiblesNumber--; // igual que coleccionablesNumber=coleccionablesNumber +1;

        collectiblesNumbersText.text=collectiblesNumber.ToString(); // to string convierte a txt

    }


}
