using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCarro : MonoBehaviour {

    public float moveSpeed = 40f;
    public float turnSpeed = 80f;
    private Rigidbody rb;
    private int coinCount = 0;
    private GUIStyle coinStyle;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) // Verificar si el objeto tiene el tag "Coin"
        {
            coinCount++;
            // Hacer el objeto moneda invisible (desactivar el renderer)
            Destroy(other.gameObject);

        }
    }

    void OnGUI()
    {
        // Dibujar el contador de monedas en la esquina superior izquierda
        GUI.Label(new Rect(10, 50, 140, 30), "Monedas: " + coinCount, coinStyle);
    }


void Start()
    {
    // Configurar el estilo del texto para las monedas
    coinStyle = new GUIStyle();
    coinStyle.fontSize = 24; // Tamaño de la fuente
    coinStyle.normal.textColor = Color.yellow; // Color del texto
    rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float currentSpeed = moveSpeed;

        // Duplica la velocidad si la tecla Espacio está presionada
        if (Input.GetKey(KeyCode.Space))
        {
            currentSpeed *= 2;
        }
        // Movimiento hacia adelante
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 forwardMovement = -transform.right * currentSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forwardMovement);
        }

        // Movimiento hacia atrás
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 backwardMovement = transform.right * currentSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + backwardMovement);
        }

        // Giro a la izquierda
        if (Input.GetKey(KeyCode.A))
        {
            float turn = -turnSpeed * Time.fixedDeltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }

        // Giro a la derecha
        if (Input.GetKey(KeyCode.D))
        {
            float turn = turnSpeed * Time.fixedDeltaTime;
            Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
            rb.MoveRotation(rb.rotation * turnRotation);
        }
    }
}


