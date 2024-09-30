using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Vector3 direccion;
    [SerializeField] float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.Translate(direccion * velocidad * Time.deltaTime);

        timer += 1 * Time.deltaTime;

        if (timer >= 2)
        {
            direccion *= -1;
            timer = 0;  
        }

    }
}
