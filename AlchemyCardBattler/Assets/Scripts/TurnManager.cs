using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    int turnState = 0; // 0 = divider, 1 = play ingredient, 2 = take action
    bool playerOne;
    public GameObject turnDivider;
    bool started;

    public List<Card> currentHand;

    public List<Card> pOneHand;
    public List<Card> pTwoHand;

    private void Start()
    {
        turnDivider.SetActive(true);
        CreateHands();

        Debug.Log(pTwoHand[0].title + ", "+ pTwoHand[1].title + ", " + pTwoHand[2].title + ", " + pTwoHand[3].title + ", " + pTwoHand[4].title);
    }

    private void Update()
    {
        switch (turnState)
        {
            case 0:
                Middle();
                break;
            case 1:
                PlayIngredient();
                break;
            default:
                break;
        }
    }

    public void Middle()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (playerOne)
            {
                playerOne = false;
                currentHand = pTwoHand;
            }
            else
            {
                playerOne = true;
                currentHand = pOneHand;
            }
            turnDivider.SetActive(false);

            if (started)
            {
                Draw();
            }
            else {
                started = true;
            }

            turnState = 1;
        }
    }
    public void Draw()
    {
        pOneHand.Add(CardInit.cm.cardList[Random.Range(0, 27)]);

        // animation code here
    }

    public void PlayIngredient()
    {

    }

    public void TakeAction()
    {

    }

    void CreateHands()
    {
        pOneHand = new List<Card>();
        pTwoHand = new List<Card>();

        for (int i = 0; i < 5; i++)
        {
            pOneHand.Add(CardInit.cm.cardList[Random.Range(0, 27)]);
        }

        for (int i = 0; i < 5; i++)
        {
            pTwoHand.Add(CardInit.cm.cardList[Random.Range(0, 27)]);
        }
    }
}
