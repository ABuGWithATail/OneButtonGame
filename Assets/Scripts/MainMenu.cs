using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private string gameScene = "GameScene";

    public void ChangeScene()
    {
        // load the game scene. this function is activated by the start game button in the main menu
        SceneManager.LoadScene(gameScene);

    }

}
