using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionParticle : MonoBehaviour
{
    
    void Update()
    {
        if (gameObject.activeSelf == false)
        {
            Destroy(gameObject);
        }
    }
}
