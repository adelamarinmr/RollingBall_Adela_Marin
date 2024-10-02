using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] float x;
    [SerializeField] float z;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
     
    }

    void Mover(float h, float v)
    {
        transform.Translate( new Vector3(h, v));
        Mover(h, v);

        float speed = Input.GetAxisRaw("Horizontal");
        transform.Translate( new Vector3(speed, h));

    }



}
