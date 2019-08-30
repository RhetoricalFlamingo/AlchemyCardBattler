using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Mouse : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public AnimationCurve myTweenCurve;
    private bool CardScaling = false;
     
    /*void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider.CompareTag("MyCard"))
            {
                if (!CardScaling)
                StartCoroutine(LerpScale());  
            }
            
        }
    }
    
    
    IEnumerator LerpScale()
    {
        CardScaling = true;
            float t = 0f;
            Vector3 startScale = hit.collider.gameObject.transform.localScale;
            Vector3 endScale = hit.collider.gameObject.transform.localScale +new Vector3(1,1,1);
            while (t < 1f)
            {
                hit.collider.gameObject.transform.localScale = Vector3.SlerpUnclamped(startScale, endScale, myTweenCurve.Evaluate(t));
                t += Time.deltaTime;
                yield return 0;
            }
        } */
    }

