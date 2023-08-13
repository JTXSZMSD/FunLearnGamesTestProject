using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour
{
    private SpriteRenderer sr;
    private float c;

    private GameObject player;
    private PlayerCollisions collisions;

    [SerializeField]
    private GameObject particleStars;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        player = GameObject.FindWithTag("Player");
        collisions = player.GetComponent<PlayerCollisions>();
    }

    void Update()
    {
        if (collisions.changeDaytime)
        {
            ChangeDaytime();
        }
    }

    private void ChangeDaytime()
    {
        c = sr.color.a;
        c -= Time.deltaTime / 2;
        sr.color = new Color(255, 255, 255, c);
        particleStars.SetActive(true);
    }
}
