using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo_Golpeador : MonoBehaviour
{
    [SerializeField] Vector3 direccionR;
    Rigidbody rB;
    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();
        rB.AddTorque(direccionR*100,ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
