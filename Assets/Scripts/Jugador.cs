using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Jugador : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad,h,v;
    [SerializeField] Vector3 direccion,direccionMove;
    [SerializeField] float timer = 0;
    [SerializeField] float fuerzaMove;
   

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
        if (Input.GetKeyDown(KeyCode.Space))
        {

            GetComponent<Rigidbody>().AddForce(new Vector3(0,3,0),ForceMode.Impulse);



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
            Destroy(other.gameObject);
        }

        





    }



}
