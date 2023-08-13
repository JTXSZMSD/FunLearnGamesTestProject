using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossDeath : MonoBehaviour
{
    private int hp = 2;
    public static bool bossIsAlive = true;


    private GameObject player;
    private PlayerCollisions collisions;

    [SerializeField]
    private GameObject particleExplosion;

    private void Update()
    {
        player = GameObject.FindWithTag("Player");
        collisions = player.GetComponent<PlayerCollisions>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            if (collisions.finishFound)
            {
                if (hp <= 0)
                {
                    Destroy(gameObject);
                    bossIsAlive = false;
                    PlayerCollisions.hasWon = true;
                }
                else
                {
                    hp -= 1;
                }
            }
            Destroy(collision.gameObject);
            Instantiate(particleExplosion, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
        }
    }
}
