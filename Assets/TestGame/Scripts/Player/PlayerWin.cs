using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWin : MonoBehaviour
{
    public static bool hasWon = false;

    public SkeletonAnimation anim;
    public PlayerMoveset moveSet;

    private void Start()
    {
        moveSet = GetComponent<PlayerMoveset>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            hasWon = true;
            moveSet.enabled = false;
            anim.loop = false;
            anim.AnimationName = "idle";
            this.enabled = false;
        }
    }
}
