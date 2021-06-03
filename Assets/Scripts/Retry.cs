using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
   public void RetryButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void StartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void Start()
    {
        FindObjectOfType<HighScoreSave>()?.LoadBinary();
    }
  

}
