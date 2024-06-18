using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Transform target; // El objetivo que la cámara seguirá (el carro)
    public Vector3 offset; // Desplazamiento de la cámara respecto al objetivo

    void LateUpdate()
    {
        // Posiciona la cámara en el objetivo con el desplazamiento especificado
        transform.position = target.position + offset;
    }

}
