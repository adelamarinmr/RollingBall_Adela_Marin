using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Plat_Mov : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Vector3 direccion;
    float timer;
  // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion*velocidad*Time.deltaTime);
        timer += Time.deltaTime;

        if(timer>=2.5)
        {
            direccion *= -1;
            timer = 0;
        }


    }




} 









