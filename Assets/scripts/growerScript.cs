using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growerScript : MonoBehaviour
{

    public spawnOnButton script;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector2.one * script.s;
    }
}
