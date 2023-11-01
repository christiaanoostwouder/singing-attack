using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    
    
    void Start()
    {
        
        StartCoroutine(SpawnEnemy());
    }

    
    void Update()
    {
        
    }

    IEnumerator SpawnEnemy()
    {
        while(true)
        {
            
            yield return new WaitForSeconds(1);
            Instantiate(enemyPrefab);
        }
    }
}
