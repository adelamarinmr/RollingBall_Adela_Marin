using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    // Start is called before the first frame update
 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindAnyObjectByType<GM>().AddColeccionable();
            Destroy(gameObject);
        }


    }
}
