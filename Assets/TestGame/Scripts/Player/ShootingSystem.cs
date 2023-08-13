using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    public GameObject bullet;

    [SerializeField]
    private GameObject particleMuzzle;

    public Transform startPoint;

    private SkeletonAnimation anim;
    private PlayerMoveset moveset;
    private PlayerCollisions collisions;

    private void Start()
    {
        moveset = GetComponent<PlayerMoveset>();
        collisions = GetComponent<PlayerCollisions>();
        anim = GetComponentInChildren<SkeletonAnimation>();
        
    }

    public void shoot()
    {
        changeAnimationToShoot();
        Invoke("spawnProjectile", 0.5f);
        particleMuzzle.SetActive(true);
        StartCoroutine(timer(1.5f));

        

    }

    private void changeAnimationToIdle()
    {
        anim.loop = true;
        anim.timeScale = 1f;
        anim.AnimationName = "idle";
    }

    private void changeAnimationToShoot()
    {
        anim.loop = false;
        anim.timeScale = 1.5f;
        anim.AnimationName = "shoot";
        if (moveset.enabled == true)
        {
            moveset.enabled = false;
        }
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

    private IEnumerator timer(float t)
    {
        yield return new WaitForSeconds(t);

        if (collisions.finishFound == false)
        {
            changeAnimationToWalk();
        }
        else if (collisions.finishFound == true)
        {
            changeAnimationToIdle();
        }
    }
}
