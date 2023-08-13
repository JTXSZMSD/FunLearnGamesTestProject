using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField]
    private GameObject particleExplosion;

    private void Update()
    {
        //if (PlayerCollisions.hasWon == true)
        //{
        //    Destroy(gameObject);
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(particleExplosion, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
        }
    }
}
