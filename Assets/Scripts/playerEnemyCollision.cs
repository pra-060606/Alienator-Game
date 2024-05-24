using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class playerEnemyCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    public float playerHealth=200;
    public Image gameOverImage;
    public GameObject canvasGameOver;
    public bool gameOver = false;
    void Start()
    {
        gameOverImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shooter"))
        {
            playerHealth -= 10;
        }
        if (playerHealth < 0)
        {
            Destroy(this.gameObject);
            gameOver = true;
            canvasGameOver.SetActive(true);
        }
    }
}

