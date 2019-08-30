using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Middle : MonoBehaviour
{
    public GameObject[] card = new GameObject[5];
    public Text[] title = new Text[5];
    public Text[] desc = new Text[5];

    private bool bootup;
    
    int turn = 0;

    private void OnEnable()
    {  
        TurnManager.tm.turnDivider.SetActive(true);

        for (int i = 0; i < 5; i++)
        {
            card[i].gameObject.SetActive(true);
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

        if (TurnManager.tm.started)
        {
            TurnManager.tm.Draw();
        }
        else if (turn > 1)
        {
            TurnManager.tm.started = true;
        }

        Hand();
        turn++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
        {
            TurnManager.tm.turnDivider.SetActive(false);
            Debug.Log(TurnManager.tm.currentHand[0].title);
            TurnManager.tm.turnState = 1;
        }
    }

    public void Hand()
    {
        for(int i = 0; i < 5; i++)
        {
            title[i].text = TurnManager.tm.currentHand[i].title;
            desc[i].text = TurnManager.tm.currentHand[i].desc;
        }
    }


}
