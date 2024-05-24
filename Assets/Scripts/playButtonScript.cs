using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayButtonHandler : MonoBehaviour
{
    public Button playButton;

    void Start()
    {
        // Get the Button component attached to the GameObject
        playButton = GetComponent<Button>();

        // Subscribe to the onClick event of the button
        playButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        // Insert your game start logic here
        Debug.Log("Game started!"); // For demonstration purposes

        // Add your game start logic here, such as loading a scene
        SceneManager.LoadScene("SampleScene");
    }
}