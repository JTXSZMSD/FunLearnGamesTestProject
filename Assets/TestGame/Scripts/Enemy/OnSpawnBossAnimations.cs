using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnSpawnBossAnimations : MonoBehaviour
{
    private GameObject player;
    private PlayerCollisions collisions;

    private SkeletonAnimation anim;
    private EnemyMoveset moveSet;

    private bool angryDone = false;


    private void Start()
    {
        anim = GetComponentInChildren<SkeletonAnimation>();
        moveSet = GetComponent<EnemyMoveset>();

        player = GameObject.FindWithTag("Player");
        collisions = player.GetComponent<PlayerCollisions>();
    }

    private void Update()
    {
        if (collisions.finishFound == true && angryDone == false)
        {
            SetAngryAnimation();
            angryDone = true;
            Invoke("StartMoving", 1f);
        }
    }

    public void SetAngryAnimation()
    {
        anim.loop = false;
        anim.AnimationName = "angry";
    }

    public void StartMoving()
    {
        anim.loop = true;
        anim.AnimationName = "run";
        moveSet.enabled = true;
    }
}
