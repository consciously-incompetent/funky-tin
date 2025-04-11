using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnOnButton : MonoBehaviour
{
    public GameObject grower;
    //public GameObject growers;
    // Update is called once per frame
    void Update()
    {
        
    }


    public void spawn()
    {
       GameObject newGrower =  Instantiate(grower);
        newGrower.transform.position = Vector2.one * Random.insideUnitCircle * 4;


    }
}
