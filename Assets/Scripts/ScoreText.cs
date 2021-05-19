using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int scoreInt;

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position.y);
        scoreText.text = player.position.y.ToString("0");

        scoreInt = (int)player.position.y;
    }
}
