using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartmenu : MonoBehaviour
{
    /// <summary>
    /// Awake is called before Start.
    /// </summary>
    private void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    /// <summary>
    /// Loads first level of the game.
    /// </summary>
    public void StartGame()

    {
        SceneManager.LoadScene(1);
    }

    /// <summary>
    /// Quits the game to the desktop.
    /// </summary>
    public void QuitToDesktop()

    {
        Application.Quit();
    }

}
