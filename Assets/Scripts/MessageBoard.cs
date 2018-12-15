using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBoard : MonoBehaviour {

    public PlayerHealth playerHealth;       // Reference to the player's heatlh.
    
    public GameObject beginCanvas;          // Begin canvas trigger.
    
    public GameObject scoreCanvas;          // Score canvas trigger.
    
    //public GameObject endCanvas;            // End canvas trigger.

    public GameObject enemyManager;         // Enemy manager game object/script.

    bool gameActive = false;            // True when score canvase is active.

    //bool endGameCanvas;           // True when the players health is 0.
    

    void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag == "projectile")
        {

            gameActive = true;

            beginCanvas.SetActive(false);
            scoreCanvas.SetActive(true);

            if (gameActive)
            {
                StartCoroutine(StartCountdown());
            }

        }
        
    }


    IEnumerator StartCountdown()
    {
        yield return new WaitForSeconds(5);

        enemyManager.SetActive(true);
    }

    /*void RestartGame()
    {
        // If the player has health left...
        if (playerHealth.currentHealth <= 0f)
        {
            scoreCanvas.SetActive(false);
            endCanvas.SetActive(true);
        }
    }
    */

 }
