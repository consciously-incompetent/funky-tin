using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtMouse : MonoBehaviour
{
 

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePos.z = 0;
        Vector2 direction = MousePos - transform.position;

        transform.up = direction;
        transform.position += transform.up * 1 * Time.deltaTime;




    }
}
