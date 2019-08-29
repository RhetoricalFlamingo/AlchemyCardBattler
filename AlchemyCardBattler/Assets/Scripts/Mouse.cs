using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Mouse : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
     
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("MyCard"))
            print (hit.collider.name);
        }
    }
}

