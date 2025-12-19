using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ChangeSceneToChoose()
    {
        SceneManager.LoadScene("choose_role");
    }
    public void ChangeSceneToTitle()
    {
        SceneManager.LoadScene("Game_Title");
    }
    public void ChangeSceneToLobby()
    {
        SceneManager.LoadScene("lobby");
    }
}