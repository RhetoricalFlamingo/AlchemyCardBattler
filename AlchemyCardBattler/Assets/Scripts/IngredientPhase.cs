using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientPhase : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        StartCoroutine(WaitToDrag());
    }

    public IEnumerator WaitToDrag()
    {
        yield return new WaitForSeconds(1.5f);
        TurnManager.tm.drag = true;
    }

    // wherever this ends, if playerone disable this, swap the playerone bool and enable the middle phase
}
