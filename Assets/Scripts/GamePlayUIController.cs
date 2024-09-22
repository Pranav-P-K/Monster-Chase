using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUIController : MonoBehaviour
{
    public void HomeButton() {
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartButton() {
        SceneManager.LoadScene("GamePlay");
    }
}
