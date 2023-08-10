using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject enemy;
    private float tempTime;

    private void Start()
    {

    }

    private void Update()
    {
        if (tempTime <= 0)
        {
            spawnEnemy();
            tempTime = 7.5f;
        }
        else 
        {
            tempTime -= Time.deltaTime;
        }
    }

    private void spawnEnemy()
    {
        Vector3 point = spawnPoint.position;
        Quaternion rotation = spawnPoint.rotation;
        Instantiate(enemy, point, rotation);
    }
}
