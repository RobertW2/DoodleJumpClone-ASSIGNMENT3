using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformSpawner;

    public int platformCount = 500;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for(int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-5f, 5f);
            Instantiate(platformSpawner, spawnPosition, Quaternion.identity);
        }

        FindObjectOfType<HighScoreSave>().LoadBinary();
    }

}
