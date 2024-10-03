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
       Rigidbody rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GetComponent<Rigidbody>().AddForce(new Vector3(0,10,0),ForceMode.Impulse);



        }

        //transform.Translate(direccion * velocidad * Time.deltaTime);

        //timer += 1 * Time.deltaTime;

        //if (timer >= 2)
        //{
        //    direccion *= -1;
        //    timer = 0;  
        

    }
}
