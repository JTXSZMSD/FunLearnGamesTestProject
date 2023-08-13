using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public static bool hasWon = false;

    [SerializeField]
    public bool finishFound = false;
    public bool bossSpawn = false;
    public bool changeDaytime = false;

    private SkeletonAnimation anim;
    private PlayerMoveset moveSet;

    private void Start()
    {
        moveSet = GetComponent<PlayerMoveset>();
        anim = GetComponentInChildren<SkeletonAnimation>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            finishFound = true;
            moveSet.enabled = false;
            anim.loop = false;
            anim.AnimationName = "idle";
        }

        if (collision.tag == "BossSpawnTimingPoint")
        {
            bossSpawn = true;
        }

        if (collision.tag == "DaytimeChangePoint")
        {
            changeDaytime = true;
        }
    }
}
