using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickShoot : MonoBehaviour
{
    private GameObject player;
    private ShootingSystem sh;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        sh = player.GetComponent<ShootingSystem>();
    }

    public void shoot()
    {
        sh.shoot();
    }

}
