using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour {

	public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    public void Menu()
    {
        SceneManager.LoadScene("Start");
    }
    public void ToggleMute()
    {
        AudioListener.volume = AudioListener.volume == 1 ? 0 : 1;
    }
}
