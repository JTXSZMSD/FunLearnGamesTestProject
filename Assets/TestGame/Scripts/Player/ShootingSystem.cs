using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public GameObject bullet;
    public Transform startPoint;
    public SkeletonAnimation anim;
    private PlayerMoveset moveset;

    private void Start()
    {
        moveset = GetComponent<PlayerMoveset>();
    }

    public void shoot()
    {
        changeAnimationToShoot();
        Invoke("spawnProjectile", 0.5f);
        Invoke("changeAnimationToWalk", 1.5f);
    }

    private void changeAnimationToShoot()
    {
        anim.loop = false;
        anim.timeScale = 1.5f;
        anim.AnimationName = "shoot";
        moveset.enabled = false;
    }

    private void changeAnimationToWalk()
    {
        anim.loop = true;
        anim.timeScale = 1f;
        anim.AnimationName = "walk";
        moveset.enabled = true;
    }

    private void spawnProjectile()
    {
        Vector3 point = startPoint.position;
        Quaternion rotation = startPoint.rotation;
        Instantiate(bullet, point, rotation);
    }
}
