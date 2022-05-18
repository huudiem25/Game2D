using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Setup()
    {
        gameObject.SetActive(true);
    }
}
