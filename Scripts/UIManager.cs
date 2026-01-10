using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerStats playerStats;
    public Slider healthBar;
    public Text hungerText;
    public Text thirstText;

    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        healthBar.value = playerStats.health;
        hungerText.text = "Lapar: " + Mathf.Round(playerStats.hunger).ToString() + "%";
        thirstText.text = "Haus: " + Mathf.Round(playerStats.thirst).ToString() + "%";
    }
}
