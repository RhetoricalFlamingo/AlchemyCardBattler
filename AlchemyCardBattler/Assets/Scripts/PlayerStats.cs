using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int HealthP1 = 3;

    public int SightP1 = 3;

    public int FullnessP1 = 0;

    public int CardsDrawnP1 = 1;

    public int AmpP1 = 1;
    
    public int HealthP2 = 3;

    public int SightP2 = 3;

    public int FullnessP2 = 0;

    public int CardsDrawnP2 = 1;

    public int AmpP2 = 1;

    private bool alive = true;
    public SpriteRenderer Witch;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        TurnManager.tm.turn++;

    }

    // Update is called once per frame
    void Update()
    {
        if (TurnManager.tm.playerOne)
        {
            switch (HealthP1)
            {
               case 1:
                   Witch.sprite = Resources.Load<Sprite>("Temps/witch char_5");
                   break;
                case 2:
                    Witch.sprite = Resources.Load<Sprite>("Temps/witch char_4");
                    break;
                case 3:
                    Witch.sprite = Resources.Load<Sprite>("Temps/witch char_3");
                    break;
                case 4:
                    Witch.sprite = Resources.Load<Sprite>("Temps/witch char_2");
                    break;
                case 5:
                    Witch.sprite = Resources.Load<Sprite>("Temps/witch char_1");
                    break;
            }
        }
        else
        {
            switch (HealthP2)
            {
                case 1:
                    Witch.sprite = Resources.Load<Sprite>("Temps/witch char_5");
                    break;
                case 2:
                    Witch.sprite = Resources.Load<Sprite>("Temps/witch char_4");
                    break;
                case 3:
                    Witch.sprite = Resources.Load<Sprite>("Temps/witch char_3");
                    break;
                case 4:
                    Witch.sprite = Resources.Load<Sprite>("Temps/witch char_2");
                    break;
                case 5:
                    Witch.sprite = Resources.Load<Sprite>("Temps/witch char_1");
                    break;
            }
        }
    }

    public void Drink()
    {
        if (TurnManager.tm.playerOne)
        {
           DrinkP1();
        }
        else
        {
           DrinkP2(); 
        }
    }

    public void Dump()
    {
        PotInventory.instance.oVisc = 0;
        PotInventory.instance.oTemp = 0;
        
        for (int i = 0; i < PotInventory.instance.colors.Length; i++)
        {
            PotInventory.instance.colors[i] = 0;
        }

        PotInventory.instance.oCol = 1;
        PotInventory.instance.potInv.Clear();
        TurnManager.tm.turnState = 0;
    }

   
    
    
    
    private void DrinkP1()
    {
       if (PotInventory.instance.oCol == 0)
            {
                if (PotInventory.instance.oVisc >= 0 && PotInventory.instance.oTemp >= -1 &&
                    PotInventory.instance.oTemp <= 1)
                {
                    HealthP1 += 1 * AmpP1;
                }
                else
                {
                    HealthP1 -= 1 * AmpP1;
                }

                FullnessP1 += 1;
                AmpP1 = 1;
            }

            if (PotInventory.instance.oCol == 2)
            {
                if (PotInventory.instance.oTemp >= -1 &&
                    PotInventory.instance.oTemp <= 1 && PotInventory.instance.oVisc >= -1 &&
                    PotInventory.instance.oVisc <= 1)
                {
                    FullnessP1 += 1 * AmpP1;
                }
                else
                {
                    FullnessP1 -= 1 * AmpP1;
                }

                FullnessP1 += 1;
                AmpP1 = 1;
            }

            if (PotInventory.instance.oCol == 3)
            {
                if (PotInventory.instance.oTemp >= -1 &&
                    PotInventory.instance.oTemp <= 1 && PotInventory.instance.oVisc >= -1 &&
                    PotInventory.instance.oVisc <= 1)
                {
                    SightP1 += 1 * AmpP1;
                }
                else
                {
                    SightP1 -= 1 * AmpP1;
                }

                FullnessP1 += 1;
                AmpP1 = 1;
            }

            if (PotInventory.instance.oCol == 4)
            {
                if (PotInventory.instance.oVisc <= 0 && PotInventory.instance.oTemp >= 0)
                {
                    CardsDrawnP1 += 1 * AmpP1;
                }
                else
                {
                    CardsDrawnP1 -= 1 * AmpP1;
                }

                FullnessP1 += 1;
                AmpP1 = 1;
            }

            if (PotInventory.instance.oCol == 5)
            {
                alive = false;
                Debug.Log("U Ded");
            }

            if (PotInventory.instance.oCol == 6)
            {
                if (PotInventory.instance.oVisc >= -1 &&
                    PotInventory.instance.oVisc <= 1 && PotInventory.instance.oTemp <= 0)
                {
                    AmpP1 = 0;
                }
                else
                {
                    AmpP1 = 2;
                }

                FullnessP1 += 1;
            }

            PotInventory.instance.oVisc = 0;
            PotInventory.instance.oTemp = 0;

            for (int i = 0; i < PotInventory.instance.colors.Length; i++)
            {
                PotInventory.instance.colors[i] = 0;
            }

            PotInventory.instance.oCol = 1;
            PotInventory.instance.potInv.Clear();
            TurnManager.tm.turnState = 0; 
        PotMoves.instance.potCanvas.SetActive(false);
    }
    
     private void DrinkP2()
    {
       if (PotInventory.instance.oCol == 0)
            {
                if (PotInventory.instance.oVisc >= 0 && PotInventory.instance.oTemp >= -1 &&
                    PotInventory.instance.oTemp <= 1)
                {
                    HealthP2 += 1 * AmpP2;
                }
                else
                {
                    HealthP2 -= 1 * AmpP2;
                }

                FullnessP2 += 1;
                AmpP2 = 1;
            }

            if (PotInventory.instance.oCol == 2)
            {
                if (PotInventory.instance.oTemp >= -1 &&
                    PotInventory.instance.oTemp <= 1 && PotInventory.instance.oVisc >= -1 &&
                    PotInventory.instance.oVisc <= 1)
                {
                    FullnessP2 += 1 * AmpP2;
                }
                else
                {
                    FullnessP2 -= 1 * AmpP2;
                }

                FullnessP2 += 1;
                AmpP2 = 1;
            }

            if (PotInventory.instance.oCol == 3)
            {
                if (PotInventory.instance.oTemp >= -1 &&
                    PotInventory.instance.oTemp <= 1 && PotInventory.instance.oVisc >= -1 &&
                    PotInventory.instance.oVisc <= 1)
                {
                    SightP2 += 1 * AmpP2;
                }
                else
                {
                    SightP2 -= 1 * AmpP2;
                }

                FullnessP2 += 1;
                AmpP2 = 1;
            }

            if (PotInventory.instance.oCol == 4)
            {
                if (PotInventory.instance.oVisc <= 0 && PotInventory.instance.oTemp >= 0)
                {
                    CardsDrawnP2 += 1 * AmpP2;
                }
                else
                {
                    CardsDrawnP2 -= 1 * AmpP2;
                }

                FullnessP2 += 1;
                AmpP2 = 1;
            }

            if (PotInventory.instance.oCol == 5)
            {
                alive = false;
                Debug.Log("U Ded");
            }

            if (PotInventory.instance.oCol == 6)
            {
                if (PotInventory.instance.oVisc >= -1 &&
                    PotInventory.instance.oVisc <= 1 && PotInventory.instance.oTemp <= 0)
                {
                    AmpP2 = 0;
                }
                else
                {
                    AmpP2 = 2;
                }

                FullnessP1 += 1;
            }

            PotInventory.instance.oVisc = 0;
            PotInventory.instance.oTemp = 0;

            for (int i = 0; i < PotInventory.instance.colors.Length; i++)
            {
                PotInventory.instance.colors[i] = 0;
            }

            PotInventory.instance.oCol = 1;
            PotInventory.instance.potInv.Clear();
            TurnManager.tm.turnState = 0;  
        PotMoves.instance.potCanvas.SetActive(false);
    }
}
