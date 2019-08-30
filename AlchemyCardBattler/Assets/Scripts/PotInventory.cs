using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotInventory : MonoBehaviour
{
    public static PotInventory instance;
    public List<Card> potInv;
    public Card one, two;

    private int tempVisc = 0;
    private int tempTemp = 0;
    private int tempAmp = 1;
    private int tempRev = 1;
    int tempCol = 0;

    public int oTemp, oVisc, oCol;

    public int[] colors = new int[7];

    public Text visc, temp, color, lOne, lTwo, lAmp, lRev;
    public GameObject tester;
    public Material Soup1;
    public Material Soup2;
    public Material Bubbles;

    public ParticleSystem Steam;

    
    private Color Red = new Vector4(60f,0,0,0f);
    private Color Blue = new Vector4(0, 5, 30,0f);
    private Color Green = new Vector4(2, 40, 0,0f);
    private Color Yellow = new Vector4(40f, 40f, 0,0f);
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        potInv = new List<Card>();
        
    }

    void Update()
    {
        var main = Steam.main;
        if (oCol == 0)
        {
            Soup1.SetColor("_Color0", Red);
            //Soup2.SetColor("_Color0", Red);
            //Bubbles.SetColor("_EmissionColor", Red);
        }else if (oCol == 2)
        {
            Soup1.SetColor("_Color0", Green);
        }
        else if (oCol == 3)
        {
            Soup1.SetColor("_Color0", Blue);
        }
        else if (oCol == 4)
        {
            Soup1.SetColor("_Color0", Yellow);
        }

        if (oTemp == 1)
        {
            main.startSize = 2;
        }
        else if (oTemp >= 2)
        {
            main.startSize = 6f;
        }
        else
        {
            main.startSize = 0;
        }
        
       

        //Soup1.SetColor("_TintColor", Red);
        Test();
    }

    void ModifyPot()
    {
        tempVisc = 0;
        tempTemp = 0;
        tempAmp = 1;
        tempRev = 1;
        
        potInv.Add(one);
        potInv.Add(two);
        
        AdjustStat(one, one.cOne, one.eOne);
        AdjustStat(one, one.cTwo, one.eTwo);
        AdjustStat(one, one.cThree, one.eThree);
        AdjustStat(one, one.cFour, one.eFour);
        
        AdjustStat(two, two.cOne, two.eOne);
        AdjustStat(two, two.cTwo, two.eTwo);
        AdjustStat(two, two.cThree, two.eThree);
        AdjustStat(two, two.cFour, two.eFour);

        oTemp += tempTemp * tempAmp * tempRev;
        oVisc += tempVisc * tempAmp * tempRev;
    }

    void AdjustStat(Card c, int chg, int eff)
    {
        switch (chg)
        {
            case 0:
                WeirdEffect(c);
                break;
            case 1:
                tempVisc += eff;
                break;
            case 2:
                tempTemp += eff;
                break;
            case 3:
                tempAmp *= eff;
                break;
            case 4:
                tempAmp *= eff;
                break;
            default:
                break;
        }    
    }

    void WeirdEffect(Card c)
    {
    }

    int ColorNum()
    {
        for (int i = 0; i < potInv.Count; i++)
        {
            colors[potInv[i].color]++;
        }

        int highNum = 0;
        int col = 0;

        for (int i = 0; i < colors.Length; i++)
        {
            if (colors[i] > highNum)
            {
                highNum = colors[i];
                col = i;
            }
            else if (colors[i] == highNum)
            {
                if (Random.Range(0, 2) > 1)
                {
                    col = i;
                }
            }
        }

        oCol = col;
        return col;
    }

    void Color(int i)
    {
        switch (i)
        {
            case 0:
                Debug.Log("red");
                color.text = "red";
                break;
            case 1:
                Debug.Log("clear");
                color.text = "clear";
                // color
                break;
            case 2:
                Debug.Log("green");
                color.text = "green";

                //color
                break;
            case 3: 
                Debug.Log("blue");
                color.text = "blue";

                //color
                break;
            case 4:
                Debug.Log("yellow");
                color.text = "yellow";

                //color
                break;
            case 5: 
                Debug.Log("black");
                color.text = "black";

                //color
                break;
            case 6:
                Debug.Log("purple");
                color.text = "purple";

                //color
                break;
            default:
                break;
        }
    }

    void Test()
    {
        tester.SetActive(true);
        visc.text = "visc " + oVisc;
        temp.text = "temp " + oTemp;
        lRev.text = "last reverse " + tempRev;
        lAmp.text = "last amp " + tempAmp;

        if (one != null && two != null)
        {
            lOne.text = "Last card one: " + one.title;
            lTwo.text = "Last card two: " + two.title;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            one = CardInit.cm.cardList[Random.Range(0, 27)];
            two = CardInit.cm.cardList[Random.Range(0, 27)];
            
            ModifyPot();
            Color(ColorNum());
        }
    }
}
