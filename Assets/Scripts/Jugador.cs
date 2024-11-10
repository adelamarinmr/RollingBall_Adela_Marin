using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad, h, v;
    [SerializeField] Vector3 direccion, direccionMove;
    [SerializeField] float timer = 0;
    [SerializeField] float fuerzaMove;
    [SerializeField] AudioClip magicSound;
    [SerializeField] Sonido manager;
    
    public Text countText;
    public Text winText;

    private int count;

    public float potenciaSalto;

    public int vidas = 3;  // Nueva variable para almacenar las vidas del jugador
    public Text livesText;  // Texto para mostrar vidas


    private RaycastHit raycastHit;
    public float longitudRaycast;
    public LayerMask raycastLayerMask;

    private int inAir;

    private bool gameEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        Physics.Raycast(transform.position, Vector3.down, out raycastHit, longitudRaycast, raycastLayerMask);

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }

        Physics.Raycast(transform.position, Vector3.down, out raycastHit, longitudRaycast, raycastLayerMask);

        // Volver al menú al presionar M
        if (Input.GetKeyDown(KeyCode.M))
        {
            LoadMenu();
        }




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
            count = count +1;
            SetCountText();
        }

        else if (other.gameObject.CompareTag("Peligro"))  // Verifica si el objeto es un peligro
        {
            vidas -= 1;  // Resta una vida
            SetLivesText();  // Actualiza el texto de vidas

            if (vidas <= 0)
            {
                winText.text = "Game Over";
                gameObject.SetActive(false);  // Desactiva al jugador
            }
        }
        else if (other.gameObject.CompareTag("PuntoDeLlegada"))  // Punto de llegada para ganar
        {
            CheckVictoryConditions();
        }
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    void SetLivesText()
    {
        livesText.text = "Lives: " + vidas.ToString();
    }

    void CheckVictoryConditions()
    {
        // Verifica si el jugador cumple las condiciones para ganar
        if (count >= 8 && (vidas >= 1 && vidas <= 3))
        {
            winText.text = "YOU WIN!";
            gameObject.SetActive(false);  // Desactiva al jugador después de ganar
        }
        else
        {
            winText.text = "GAME OVER";
        }
    }
    void GameOver()
    {
        winText.text = "Game Over";
        gameEnded = true;
        Invoke("AllowRestart", 2f);  // Espera 2 segundos antes de permitir reiniciar
    }

    void AllowRestart()
    {
        gameEnded = true; // Permite reiniciar después de 2 segundos
    }

    void RestartGame()
    {
        gameEnded = false; // Restablece el estado de finalización del juego
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Recarga la escena actual
    }

    void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");  // Cargar la escena del menú
    }
}

   



    


