using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Experimental.Playables;

public class ChangeColourOnSpace : MonoBehaviour
{
    public SpriteRenderer sprite;
    public TrailRenderer trail;
    public Color col;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            col = Random.ColorHSV();
            sprite.color = col;
            //trail.materials[0].color = Color.red;
            trail.startColor = col;
            trail.endColor = Random.ColorHSV();
            

        }
    }
}
