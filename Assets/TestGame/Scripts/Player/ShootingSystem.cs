using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public GameObject bullet;
    public Transform startPoint;

    public void shoot()
    {
            Vector3 point = startPoint.position;
            Quaternion rotation = startPoint.rotation;
            Instantiate(bullet, point, rotation);
    }
}
