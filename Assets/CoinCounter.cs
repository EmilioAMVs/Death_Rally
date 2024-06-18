using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int coinCount = 0;
    private GUIStyle coinStyle;

    public float rotationSpeed = 300f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Rotar la moneda en su propio eje local (eje Y)
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime);
    }
}
