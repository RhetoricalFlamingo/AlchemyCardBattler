using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public static TurnManager tm;

    public int turnState = 0; // 0 = divider, 1 = play ingredient, 2 = take action
    public bool playerOne = false;
    public GameObject turnDivider;
    public bool started, drag;

    public List<Card> currentHand;

    public List<Card> pOneHand;
    public List<Card> pTwoHand;

    public GameObject cardPrefab;

    public List<GameObject> card = new List<GameObject>();
    public List<Text> title = new List<Text>();
    public List<Text> desc = new List<Text>();

    public int turn = 0;

    private void Awake()
    {

        if (tm == null)
        {
            tm = this;
        }
        else if (tm != this)
        {
            Destroy(this);
        }
    }

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
                GetComponent<Middle>().enabled = true;
                GetComponent<IngredientPhase>().enabled = false;
                GetComponent<ActionTurn>().enabled = true;
                break;
            case 1:
                GetComponent<Middle>().enabled = false;
                GetComponent<IngredientPhase>().enabled = true;
                break;
            case 2:
                GetComponent<Middle>().enabled = false;
                GetComponent<ActionTurn>().enabled = true;
                break;
            default:
                break;
        }

        if ((float)turn % 2 != 0)
        {
            playerOne = false;
        }
        else
        {
            playerOne = true;
        }


        Debug.Log(turnState);
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
