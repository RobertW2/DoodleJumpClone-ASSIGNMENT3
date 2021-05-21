using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class DeathScript : MonoBehaviour
{
    public int saveScore;
    //public Text text;
    [SerializeField] ScoreText _text;


    void OnTriggerEnter2D(Collider2D other)
    {
      //  Destroy(other.gameObject);
        saveScore = _text.scoreInt;
       // text.text = saveScore.ToString();


        SceneManager.LoadScene("DeathScene");
    }

}
