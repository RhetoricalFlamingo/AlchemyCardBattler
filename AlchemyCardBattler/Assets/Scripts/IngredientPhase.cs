using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientPhase : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnEnable()
    {
        if (TurnManager.tm.turn > 0)
        {
            TurnManager.tm.card.Add(Instantiate(TurnManager.tm.cardPrefab, new Vector3(0, -3.16f, -0.97f), Quaternion.identity));
            TurnManager.tm.title.Add(TurnManager.tm.card[TurnManager.tm.card.Count - 1].GetComponentInChildren<Canvas>().transform.Find("title").GetComponent<Text>());
            TurnManager.tm.desc.Add(TurnManager.tm.card[TurnManager.tm.card.Count - 1].GetComponentInChildren<Canvas>().transform.Find("desc").GetComponent<Text>());
            Debug.Log("NEW");
        }

        StartCoroutine(WaitToDrag());

        if (TurnManager.tm.started)
        {
            Draw();
        }

        this.GetComponent<Middle>().Hand();
        TurnManager.tm.turn++;
    }


    public void Draw()
    {
        if (TurnManager.tm.playerOne)
        {
            TurnManager.tm.pOneHand.Add(CardInit.cm.cardList[Random.Range(0, 27)]);
            TurnManager.tm.card.Add(Instantiate(TurnManager.tm.cardPrefab, new Vector3(0, -3.16f, -0.97f), Quaternion.identity));
            TurnManager.tm.title.Add(TurnManager.tm.card[TurnManager.tm.card.Count - 1].transform.Find("title").GetComponent<Text>());
            TurnManager.tm.desc.Add(TurnManager.tm.card[TurnManager.tm.card.Count - 1].transform.Find("desc").GetComponent<Text>());
        }
        else
        {
            TurnManager.tm.pTwoHand.Add(CardInit.cm.cardList[Random.Range(0, 27)]);
            TurnManager.tm.card.Add(Instantiate(TurnManager.tm.cardPrefab, new Vector3(0, -3.16f, -0.97f), Quaternion.identity));
            TurnManager.tm.title.Add(TurnManager.tm.card[TurnManager.tm.card.Count - 1].transform.Find("title").GetComponent<Text>());
            TurnManager.tm.desc.Add(TurnManager.tm.card[TurnManager.tm.card.Count - 1].transform.Find("desc").GetComponent<Text>());
        }

        // animation code here
    }

    public IEnumerator WaitToDrag()
    {
        yield return new WaitForSeconds(1.5f);
        TurnManager.tm.drag = true;
    }
}
