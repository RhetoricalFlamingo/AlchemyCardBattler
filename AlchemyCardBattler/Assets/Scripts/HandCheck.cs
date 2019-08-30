using System.Collections;

using UnityEngine;

public class HandCheck : MonoBehaviour
{
    public bool bigBoi = false;
    public AnimationCurve myTweenCurve;

    public Vector3 StandardCardSize;

    public Vector3 EndCardSize;

    public bool holding;
    RaycastHit hit;
    Ray ray;
    int layerMask = 1 << 9;
    
    // Start is called before the first frame update
    void Start()
    {
        StandardCardSize = gameObject.transform.localScale;
        EndCardSize = StandardCardSize * 2;
    }

    // Update is called once per frame
    void Update()
    { 
        
        if (holding)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit)) {
                gameObject.transform.position = hit.point;
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
                {
                    if (Input.GetMouseButtonDown(0) && hit.collider.CompareTag("Cauldron"))
                    {
                        Debug.Log("PlayCard");
                    }
                }
               
            }
        }
    }

 
    private void OnMouseOver()
    {
        if (!bigBoi)
        {
            StartCoroutine(LerpScale());
        }

            if (Input.GetMouseButtonDown(0))
            {
                

                switch (holding)
                {
                    case true:
                        holding = false;
                        break;
                    case false:
                        holding = true;
                        break;
                        
                }
          
            }
       
    }

    private void OnMouseExit()
    {
        StartCoroutine(LerpScaleBack());
    }
    IEnumerator LerpScale()
    {
        bigBoi = true;
        float t = 0f;
        Vector3 startScale = gameObject.transform.localScale;
        Vector3 endScale = EndCardSize;
        while (t < 1f)
        {
            gameObject.transform.localScale = Vector3.SlerpUnclamped(startScale, endScale, myTweenCurve.Evaluate(t));
            t += Time.deltaTime;
            yield return 0;
            if (!bigBoi)
            {
                break;
            }
        }
    }

    IEnumerator LerpScaleBack()
    {
        bigBoi = false;
        float t = 0f;
        Vector3 startScale = gameObject.transform.localScale;
        Vector3 endScale = StandardCardSize;
        while (t < 1f)
        {
            gameObject.transform.localScale = Vector3.SlerpUnclamped(startScale, endScale, myTweenCurve.Evaluate(t));
            t += Time.deltaTime;
            yield return 0;
            if (bigBoi)
            {
                break;
            }
        }
    }
}

