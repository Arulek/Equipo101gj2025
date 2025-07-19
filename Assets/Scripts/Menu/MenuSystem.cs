using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour 
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }

    public void Salir()
    {
        UnityEngine.Debug.Log("Saliendo del juego");
        Application.Quit();
    }
    
}
