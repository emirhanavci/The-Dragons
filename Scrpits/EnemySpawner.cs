using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float xLimit;
    [SerializeField]
    private float[] xPositions;
    [SerializeField]
    private Wave[] wave;

    private float currentTime;

    List<float> remainingPositions = new List<float>();
    private int waveIndex;
    float xPos = 0;
    int rand;


    void Start()
    {
        currentTime = 0;
        remainingPositions.AddRange(xPositions);
    }


    void Update()
    {
        if (Player.instance.StartMoving == true && MenuManager.instance.gameOver == false)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                SelectWave();
            }
        }
    }

    void SpawnEnemy(float xPos)
    {
        int r = Random.Range(0, 4);
        string enemyName = "";
        if (r == 0) enemyName = "Enemy1";
        else if (r == 1) enemyName = "Enemy2";
        else if (r == 2) enemyName = "Enemy3";
        else if (r == 3) enemyName = "Enemy4";


        GameObject enemy = ObjectPooling.instance.GetPooledObject(enemyName);
        enemy.transform.position = new Vector3(xPos, transform.position.y, 0);
        enemy.SetActive(true);



        // 4 tane düþman olduðu için
        //  GameObject enemyObj = Instantiate(enemyPrefabs[r], new Vector3(xPos, transform.position.y, 0), Quaternion.identity);
    }

    void SelectWave()
    {

          remainingPositions = new List<float>();
          remainingPositions.AddRange(xPositions);

          waveIndex = Random.Range(0, wave.Length);

          currentTime = wave[waveIndex].delayTime;

        if (wave[waveIndex].spawnAmount == 1)
        {
            xPos = Random.Range(-xLimit, xLimit);
        }
        else if (wave[waveIndex].spawnAmount > 1)
        {
            rand = Random.Range(0, remainingPositions.Count);
            xPos = remainingPositions[rand];
            remainingPositions.RemoveAt(rand);
        }

        for (int i = 0; i < wave[waveIndex].spawnAmount; i++)
        {
            SpawnEnemy(xPos);
            rand = Random.Range(0, remainingPositions.Count);
            xPos = remainingPositions[rand];
            remainingPositions.RemoveAt(rand);
        }

    }
}
[System.Serializable]
public class Wave
{
    public float delayTime;
    public float spawnAmount;
}

