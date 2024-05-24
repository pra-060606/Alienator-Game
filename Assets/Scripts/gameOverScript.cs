/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Image gameOverImage;
    public GameObject canvasGameOver;
   // public playerEnemyCollision playerEnemyCollision;
    void Start()
    {
     //   gameOverImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if (playerEnemyCollision.gameOver)
       // {
        //    gameOverImage.enabled = true;
       //     canvasGameOver.SetActive(true);
        
   // }  
    }
}  */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour
{
    public Image gameOverImage;
    public GameObject canvasGameOver;

    void Start()
    {
        gameOverImage.enabled = false;
        canvasGameOver.SetActive(false);
    }

    public void TriggerGameOver()
    {
        gameOverImage.enabled = true;
        canvasGameOver.SetActive(true);
        //Time.timeScale = 0f; // Pause the game
    }
}

