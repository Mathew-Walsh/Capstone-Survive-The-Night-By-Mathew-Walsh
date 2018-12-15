using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class ScoreManager : MonoBehaviour
{


    public static int score;        // The player's score.


    public TextMeshProUGUI scoreText;                      // Reference to the Text component.


    void Awake()
    {
        // Set up the reference.
        scoreText = GetComponentInChildren<TextMeshProUGUI>();

        // Reset the score.
        score = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        scoreText.text = " Score: " + score;
    }
}