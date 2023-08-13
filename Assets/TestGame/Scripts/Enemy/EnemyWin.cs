using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWin : MonoBehaviour
{
    private SkeletonAnimation anim;
    private EnemyMoveset moveSet;

    private void Start()
    {
        moveSet = GetComponent<EnemyMoveset>();
        anim = GetComponentInChildren<SkeletonAnimation>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            moveSet.enabled = false;
            anim.loop = false;
            anim.AnimationName = "win";
            this.enabled = false;
        }
    }
}
