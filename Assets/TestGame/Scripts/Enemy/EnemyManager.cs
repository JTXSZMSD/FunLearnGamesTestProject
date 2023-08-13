using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform spawnPoint;

    public GameObject enemy;
    public GameObject boss;

    private float tempTime;
    public bool bossSpawned = false;

    private GameObject player;
    private PlayerCollisions collisions;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        collisions = player.GetComponent<PlayerCollisions>();
    }

    private void Update()
    {
        if (tempTime <= 0 && bossSpawned == false)
        {
            SpawnEnemy();
            tempTime = 7.5f;
        }
        else 
        {
            tempTime -= Time.deltaTime;
        }

        if (collisions.bossSpawn == true && bossSpawned == false)
        {
            SpawnBoss();
            bossSpawned = true;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 point = spawnPoint.position;
        Quaternion rotation = spawnPoint.rotation;
        Instantiate(enemy, point, rotation);
    }

    public void SpawnBoss()
    {
        Vector3 point = new Vector3(81.5f, -5f, 0f);
        Quaternion rotation = new Quaternion(0f, 0f, 0f, 0f);
        Instantiate(boss, point, rotation);
    }
}
