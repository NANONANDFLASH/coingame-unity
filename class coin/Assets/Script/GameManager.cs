using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject winPanel;
    public Text scoreText;
    int score = 0;
    int coinCount;

    void Start()
    {
        coinCount = FindObjectsOfType<Coin>().Length / 2;
    }

    public void Gotcoin()
    {
        score += 100;
        Debug.Log(score);
        scoreText.text = $"점수 : {score}";

        coinCount--;

        if (coinCount <= 0)
        {
            winPanel.SetActive(true);

        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
