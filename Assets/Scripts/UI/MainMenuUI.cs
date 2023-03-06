using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        playButton.onClick.AddListener(() =>
        {         
            // SceneManager.LoadScene(1); // Unity->File->Build Setting
            Loader.Load(Loader.Scene.GameScene);
        });    // Delegate
        quitButton.onClick.AddListener(() =>
        {         
            Application.Quit();
        });    // Delegate

        Time.timeScale = 1f;
    }
}
