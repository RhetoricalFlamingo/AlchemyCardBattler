using System.Collections;

using UnityEngine;

public class HandCheck : MonoBehaviour
{
    public bool bigBoi = false;
    public AnimationCurve myTweenCurve;

    public Vector3 StandardCardSize;

    public Vector3 EndCardSize;
    private Vector3 OriginalCardPos;

    public bool holding;
    RaycastHit hit;
    Ray ray;
    int layerMask = 1 << 9;

    private bool placing = false;
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
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(newPosition);

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
                {
                    placing = true;
                    
                    
                    if (Input.GetMouseButtonDown(0) && hit.collider.CompareTag("Cauldron"))
                    {
                        Debug.Log("PlayCard");

                    TurnManager.tm.turnState = 0;
                    Destroy(this.gameObject);

                    holding = false;
                      

                    }
                   
                }
                else
                {
                    placing = false;
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
                    if (!placing) {
                    holding = false;
                    gameObject.transform.position = OriginalCardPos;
                }
                    break;
                case false:
                    holding = true;
                    OriginalCardPos = gameObject.transform.position;
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

