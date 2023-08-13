using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinParticleManager : MonoBehaviour
{
    [SerializeField]
    private GameObject conf1;
    [SerializeField]
    private GameObject conf2;
    [SerializeField]
    private GameObject pumpkins;

    private bool particlesIsActive = false;

    void Start()
    {
        //conf1 = GameObject.Find("Confetti1");
        //conf2 = GameObject.Find("Confetti2");
        //pumpkins = GameObject.Find("Pumpkins");
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCollisions.hasWon && !particlesIsActive)
        {
            conf1.SetActive(true);
            conf2.SetActive(true);
            pumpkins.SetActive(true);
            particlesIsActive = true;
        }
    }
}
