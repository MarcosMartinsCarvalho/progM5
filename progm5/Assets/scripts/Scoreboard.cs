using TMPro;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text textField;

    private void Start()
    {
        textField = GetComponent<TMP_Text>();
        Pickup.OnPickupCollected += AddScore;
    }

    private void AddScore()
    {
        score += 50;
        textField.text = "Score: " + score;
    }
}
