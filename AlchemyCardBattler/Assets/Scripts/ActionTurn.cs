using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTurn : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Debug.Log("KILL ME");
        TurnManager.tm.turn++;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
