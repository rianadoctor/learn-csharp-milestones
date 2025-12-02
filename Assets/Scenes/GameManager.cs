// CH 8
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int _health = 3;
    private int _items = 0;

    public int Health
    {
        get { return _health; }
        set
        {
            _health = value;
            UpdateUI();

            if (_health <= 0)
                LoseGame();
        }
    }

    public int Items
    {
        get { return _items; }
        set
        {
            _items = value;
            UpdateUI();
        }
    }

    // UI
    public Text healthText;
    public Text itemText;
    public Text winText;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateUI();
        winText.gameObject.SetActive(false);
    }


    public void AddItem()
    {
        Items++; // uses the property setter
    }

    public void TakeDamage()
    {
        Health--; // uses the property setter
    }

    void UpdateUI()
    {
        healthText.text = "Health: " + Health;
        itemText.text = "Items: " + Items;
    }

    // Win/Lose conditions
    public void WinGame()
    {
        winText.text = "YOU WIN!";
        winText.gameObject.SetActive(true);
        Time.timeScale = 0;  // pause game
    }

    public void LoseGame()
    {
        winText.text = "GAME OVER";
        winText.gameObject.SetActive(true);
        Time.timeScale = 0;  // pause game
    }
}
