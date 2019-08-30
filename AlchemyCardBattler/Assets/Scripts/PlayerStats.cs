using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int Health = 3;

    public int Sight = 3;

    public int Fullness = 0;

    public int CardsDrawn = 1;

    public int Amp = 1;

    private bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Drink()
    {
        if (PotInventory.instance.oCol == 0)
        {
            if (PotInventory.instance.oVisc >= 0 && PotInventory.instance.oTemp >= -1 &&
                PotInventory.instance.oTemp <= 1)
            {
                Health += 1 * Amp;
            }
            else
            {
                Health -= 1 * Amp;
            }

            Fullness += 1;
            Amp = 1;
        }

        if (PotInventory.instance.oCol == 2)
        {
            if (PotInventory.instance.oTemp >= -1 &&
                PotInventory.instance.oTemp <= 1 && PotInventory.instance.oVisc >= -1 &&
                PotInventory.instance.oVisc <= 1)
            {
                Fullness += 1 * Amp;
            }
            else
            {
                Fullness -= 1 * Amp;
            }

            Fullness += 1;
            Amp = 1;
        }

        if (PotInventory.instance.oCol == 3)
        {
            if (PotInventory.instance.oTemp >= -1 &&
                PotInventory.instance.oTemp <= 1 && PotInventory.instance.oVisc >= -1 &&
                PotInventory.instance.oVisc <= 1)
            {
                Sight += 1 * Amp;
            }
            else
            {
                Sight -= 1 * Amp;
            }

            Fullness += 1;
            Amp = 1;
        }

        if (PotInventory.instance.oCol == 4)
        {
            if (PotInventory.instance.oVisc <= 0 && PotInventory.instance.oTemp >= 0)
            {
                CardsDrawn += 1 * Amp;
            }
            else
            {
                CardsDrawn -= 1 * Amp;
            }

            Fullness += 1;
            Amp = 1;
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
                Amp = 0;
            }
            else
            {
                Amp = 2;
            }

            Fullness += 1;
        }

        PotInventory.instance.oVisc = 0;
        PotInventory.instance.oTemp = 0;
        
        for (int i = 0; i < PotInventory.instance.colors.Length; i++)
        {
            PotInventory.instance.colors[i] = 0;
        }

        PotInventory.instance.oCol = 1;
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
    }
}
