using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Vector2 spawnPoint;
    

  
    public void spawnEnemy()
    {
        for (var i = 0; i < 1; i++)
        {
            GameObject clone =Instantiate(enemy, spawnPoint, Quaternion.identity);
            
        }
    }
}
