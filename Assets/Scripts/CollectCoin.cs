using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    int score;
    public TextMeshProUGUI scoreText;
    int increaseRate = 1;

    void Start()
    {

    }
    void FixedUpdate()
    {
        UpdateScore();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            AddCoin();
            Destroy(other.gameObject);
        }
    }
    public void AddCoin()
    {
        score += 50;
        scoreText.text = score.ToString();
    }
    public void UpdateScore()
    {
        score += increaseRate;
        scoreText.text = score.ToString();
    }
}
