using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para gestionar escenas

public class MenuController : MonoBehaviour
{
    // M�todo para cambiar a la escena de juego
    public void Jugar()
    {
        SceneManager.LoadScene("Prueba 2");
    }

    // M�todo para salir del juego
    public void Salir()
    {
        // Si est�s en el editor de Unity
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Si est�s en una build
        Application.Quit();
#endif
    }
}
