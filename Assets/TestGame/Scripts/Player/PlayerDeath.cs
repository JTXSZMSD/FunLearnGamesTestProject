using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private SkeletonAnimation anim;
    private PlayerMoveset moveSet;

    private void Start()
    {
        moveSet = GetComponent<PlayerMoveset>();
        anim = GetComponentInChildren<SkeletonAnimation>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            moveSet.enabled = false;
            anim.loop = false;
            anim.AnimationName = "loose";
            this.enabled = false;
        }
    }
}
