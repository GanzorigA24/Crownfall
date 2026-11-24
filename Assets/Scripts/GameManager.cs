using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public UnitHealth playerCastle;
    public UnitHealth enemyCastle;
    public TMP_Text resultText;

    private bool gameEnded = false;

    void Start()
    {
        resultText.text = "";
    }

    void Update()
    {
        if (gameEnded)
            return;

        // Player wins when the enemy castle is destroyed.
        if (enemyCastle == null)
        {
            EndGame("VICTORY! You destroyed the enemy castle!", "VICTORY!");
        }
        // Player loses when their own castle is destroyed.
        else if (playerCastle == null)
        {
            EndGame("DEFEAT! Your castle was destroyed!", "DEFEAT!");
        }
    }

    void EndGame(string message, string displayText)
    {
        gameEnded = true;

        Debug.Log(message);

        resultText.text = displayText;

        Time.timeScale = 0f;
    }
}