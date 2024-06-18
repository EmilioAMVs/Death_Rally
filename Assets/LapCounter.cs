using UnityEngine;

public class LapCounter : MonoBehaviour
{
    private int lapCount = 0;
    private GUIStyle lapStyle;

    void Start()
    {
        // Configurar el estilo del texto para las vueltas
        lapStyle = new GUIStyle();
        lapStyle.fontSize = 24; // Tamaño de la fuente
        lapStyle.normal.textColor = Color.white; // Color del texto
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car")) // Asegúrate de que el objeto coche tenga el tag "Car" para contar vueltas
        {
            lapCount++;
        }
    }

    void OnGUI()
    {
        // Dibujar el contador de vueltas en la esquina superior derecha
        GUI.Label(new Rect(Screen.width - 150, 10, 140, 30), "Vueltas: " + lapCount, lapStyle);
    }
}
