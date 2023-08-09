using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWin : MonoBehaviour
{
    public SkeletonAnimation anim;
    public EnemyMoveset moveSet;

    private void Start()
    {
        moveSet = GetComponent<EnemyMoveset>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            moveSet.enabled = false;
            anim.AnimationName = "win";
            anim.loop = false;
            this.enabled = false;
        }
    }
}
