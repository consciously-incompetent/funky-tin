using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class particleAccelarator : MonoBehaviour
{
    public Image image;
    Color startColor;

    // Update is called once per frame
    private void Start()
    {
        startColor = image.color;
    }

    
    


    public void Shift()
    {
        image.color = Color.red;
    }

    public void unShift()
    {
        image.color = startColor;
    }
}
