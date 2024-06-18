using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para gestionar escenas

public class MenuController : MonoBehaviour
{
    // Método para cambiar a la escena de juego
    public void Jugar()
    {
        SceneManager.LoadScene("Prueba 2");
    }

    // Método para salir del juego
    public void Salir()
    {
        // Si estás en el editor de Unity
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Si estás en una build
        Application.Quit();
#endif
    }
}
