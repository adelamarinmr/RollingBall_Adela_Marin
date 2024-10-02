using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    Vector3 direccion= new Vector3(0f,0f,0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        direccion.z = v;
        direccion.x = h;
     transform.Translate(direccion.normalized*Time.deltaTime);

    }

    
    



}
