using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class spawnOnClick : MonoBehaviour
{
    public GameObject pointer;
    public UnityEvent OnClick;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnClick.Invoke();
        }



    }



    public void Spawn()
    {
        GameObject newPointer = Instantiate(pointer);
        newPointer.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
