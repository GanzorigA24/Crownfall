using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public UnitHealth playerCastle;
    public UnitHealth enemyCastle;
    public TMP_Text resultText;
    public Button restartButton;

    private bool gameEnded = false;

    void Start()
    {
        resultText.text = "";
        restartButton.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (gameEnded)
            return;

        if (enemyCastle == null)
        {
            EndGame("VICTORY!");
        }
        else if (playerCastle == null)
        {
            EndGame("DEFEAT!");
        }
    }

    void EndGame(string displayText)
    {
        gameEnded = true;
        resultText.text = displayText;
        restartButton.gameObject.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}