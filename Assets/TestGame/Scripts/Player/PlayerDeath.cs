using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public SkeletonAnimation anim;
    public PlayerMoveset moveSet;

    private void Start()
    {
        moveSet = GetComponent<PlayerMoveset>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            moveSet.enabled = false;
            anim.AnimationName = "loose";
            anim.loop = false;
            anim.loop = true;
            anim.loop = false;
            this.enabled = false;
        }
    }
}
