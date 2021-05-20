using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class HighScoreSave : MonoBehaviour
{
    private string FilePath => Application.streamingAssetsPath + "/highScore";

    public ScoreText text;



    private void Start()
    {
        if (!Directory.Exists(Application.streamingAssetsPath))
            Directory.CreateDirectory(Application.streamingAssetsPath);
    }

    public void SaveBinary()
    {
        // This opens 'River' between the RAM and the file
        using (FileStream stream = new FileStream(FilePath + ".save", FileMode.OpenOrCreate))
        {

            // Like creating the boat that will carry the data from one point to another
            BinaryFormatter formatter = new BinaryFormatter();

            ScoreData data = new ScoreData(text.scoreInt);
            // Transports the data from the RAM to the specified file, like freezing water
            // into ice.
            formatter.Serialize(stream, data);
        }
    }

    public void LoadBinary()
    {
        // If there is no save data, we shouldnt attempt to load it
        if (!File.Exists(FilePath + ".save"))
            return;

        // This opens 'River' between the RAM and the file
        using (FileStream stream = new FileStream(FilePath + ".save", FileMode.Open))
        {

            // Like creating the boat that will carry the data from one point to another
            BinaryFormatter formatter = new BinaryFormatter();
            // Transports the data from the RAM to the specified file, like freezing water
            // into ice.
            ScoreData data = formatter.Deserialize(stream) as ScoreData;
            // Display it here using data
            // Leaderboard.
            //   highScore.text = data.scoreInt.ToString();
            Debug.Log(data);
        }
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Save"))
        {
            // Saves the game.
            SaveBinary();
        }


        if (GUILayout.Button("Load"))
        {
            // Loads the game.
            LoadBinary();
        }
    }


}
