using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int enemySpawnCount;
    public int waveCounter = 1;
    public int enemyCount;
    

    
     void SpawnEnemyWave(int enemySpawnCount){
        for(int i = 0; i < enemySpawnCount; i++){
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            int randomRangeSpawnX = Random.Range(-10, 10);
            int randomRangeSpawnZ = Random.Range(-10, 10);
            
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(randomRangeSpawnX, 1, randomRangeSpawnZ), 
            enemyPrefabs[enemyIndex].transform.rotation ); }
    } 
   
    void Start()
    {
        SpawnEnemyWave(waveCounter);
    }

    

    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0) {waveCounter++; SpawnEnemyWave(waveCounter);}
      
    }
}
