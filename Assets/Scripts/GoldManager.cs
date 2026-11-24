using UnityEngine;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public int startingGold = 200;
    private int currentGold;

    public TMP_Text goldText;

    void Start()
    {
        currentGold = startingGold;
        UpdateGoldUI();
    }

    public void AddGold(int amount)
    {
        currentGold += amount;
        UpdateGoldUI();

        Debug.Log("Gold increased: " + currentGold);
    }

    public bool SpendGold(int amount)
    {
        if (currentGold < amount)
        {
            Debug.Log("Not enough gold!");
            return false;
        }

        currentGold -= amount;
        UpdateGoldUI();

        Debug.Log("Gold spent. Remaining gold: " + currentGold);
        return true;
    }

    void UpdateGoldUI()
    {
        goldText.text = "Gold: " + currentGold;
    }
}