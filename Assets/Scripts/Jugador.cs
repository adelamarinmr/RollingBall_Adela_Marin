using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class Jugador : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad, h, v;
    [SerializeField] Vector3 direccion, direccionMove;
    [SerializeField] float timer = 0;
    [SerializeField] float fuerzaMove;
    [SerializeField] AudioClip magicSound;
    [SerializeField] Sonido manager;
   


    public float potenciaSalto;
    

    private RaycastHit raycastHit;
    public float longitudRaycast;
    public LayerMask raycastLayerMask;

    private int inAir;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        Physics.Raycast(transform.position, Vector3.down, out raycastHit, longitudRaycast, raycastLayerMask);

        if (raycastHit.collider != null)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (inAir == 2)
                {
                    inAir = 0;
                }

                if (inAir == 0) // 0 significa que la bola está en el suelo
                {
                    GetComponent<Rigidbody>().AddForce(new Vector3(0, potenciaSalto, 0), ForceMode.Impulse);
                    inAir = 1; // 1 significa que la bola ha iniciado el salto
                }
            }
            else
            {
                inAir = 2; // 2 significa que la bola ha iniciado el salto y además, se ha dejado de detectar el collider
            }


             
        }



        //transform.Translate(direccion * velocidad * Time.deltaTime);

        //timer += 1 * Time.deltaTime;

        //if (timer >= 2)
        //{
        //    direccion *= -1;
        //    timer = 0;  


    }
    private void FixedUpdate()
    {
        direccionMove = new Vector3(h, 0, v);
        rb.AddForce((direccionMove).normalized * fuerzaMove, ForceMode.Force);

    }

   


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            manager.ReproducirSonido(magicSound);

            other.gameObject.SetActive(false);
        }
       

    }


    
}

