using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnOnButton : MonoBehaviour
{
    public GameObject grower;
    public Slider slider;
    public float growAmounnt;
    public float s  = 0;
    //public GameObject growers;
    // Update is called once per frame
    void Update()
    {
        
    }


    public void spawn()
    {
       GameObject newGrower =  Instantiate(grower);
        newGrower.GetComponent<growerScript>().script = this;
        newGrower.transform.position = Vector2.one * Random.insideUnitCircle * 4;
    }


    public void StartGrow()
    {

            StartCoroutine(Grow());
            growAmounnt = slider.value;
        

    }



    public IEnumerator Grow()
    {

        while (s != growAmounnt)
        {
           

           if(s < growAmounnt)
            {
                s += 0.01f * Time.deltaTime;
            }

           if(s > growAmounnt)
            {
                s -= 0.01f * Time.deltaTime;
            }
            
            
            yield return null;
        }


        





    }
}
