using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Middle : MonoBehaviour
{
    private bool bootup;
    public GameObject pOne, pTwo;


    private void OnEnable()
    {  
        TurnManager.tm.turnDivider.SetActive(true);
         
        for (int i = 0; i < TurnManager.tm.card.Count; i++)
        {
            Debug.Log("Cleaning");
            if (TurnManager.tm.card[i] == null)
            {
                TurnManager.tm.card.RemoveAt(i);
                TurnManager.tm.title.RemoveAt(i);
                TurnManager.tm.desc.RemoveAt(i);
            }
        }

        if (TurnManager.tm.playerOne)
        {
            TurnManager.tm.playerOne = false;
            TurnManager.tm.currentHand = TurnManager.tm.pTwoHand;
        }
        else
        {
            TurnManager.tm.playerOne = true;
            TurnManager.tm.currentHand = TurnManager.tm.pOneHand;
        }

        Hand();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            TurnManager.tm.turnDivider.SetActive(false);
            Debug.Log(TurnManager.tm.currentHand[0].title);

            if (TurnManager.tm.turnState % 2 == 0)
            {

            }
            TurnManager.tm.turnState = 1;
        }
    }

    public void Hand()
    {
        for(int i = 0; i < TurnManager.tm.card.Count; i++)
        {
            TurnManager.tm.title[i].text = TurnManager.tm.currentHand[i].title;
            TurnManager.tm.desc[i].text = TurnManager.tm.currentHand[i].desc;
        }
    }


}
