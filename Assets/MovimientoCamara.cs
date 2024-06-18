using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    public Transform target; // El objetivo que la c�mara seguir� (el carro)
    public Vector3 offset; // Desplazamiento de la c�mara respecto al objetivo

    void LateUpdate()
    {
        // Posiciona la c�mara en el objetivo con el desplazamiento especificado
        transform.position = target.position + offset;
    }

}
